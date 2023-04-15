using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics.Modules {

    internal class BoxCollection : ICollection<Box> {

        //Create the list in which we store items in this file
        private List<Box> boxCol;

        public BoxCollection() { boxCol = new List<Box>(); }

        public Box this[int index] {
            get { return (Box)boxCol[index]; }
            set { boxCol[index] = value; }
        }

        public int Count {
            get { return boxCol.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Box item) {
            
            if (!Contains(item)) {
                boxCol.Add(item);
            }
            else {
                Console.WriteLine($"Box with height : {item.height} | width : {item.width} | lenght : {item.lenght} Was already added");
            }

        }

        public void Clear() {
            throw new NotImplementedException();
        }

        public bool Contains(Box item) {

            bool found = false;

            //Go trough each item in the list and find if the certain box already exists
            foreach (Box b in boxCol) {
                if (b.Equals(item))
                    found = true;
            }

            return found;
        }

        public bool Contains(Box item, EqualityComparer<Box> comp) {

            bool found = false;
            foreach (Box b in boxCol) {
                if (comp.Equals(b, item))
                    found = true;
            }

            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex) {

            if (array == null)
                throw new ArgumentNullException("The array cannot bne null");
            if (arrayIndex < 0)
                throw new ArgumentNullException("The starting array index cannot be less than zero");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection");

            for (int i = 0; i < boxCol.Count; i++)
                array[i + arrayIndex] = boxCol[i];
        }

        public IEnumerator<Box> GetEnumerator() {

            return new BoxEnumarator(this);

        }

        public bool Remove(Box item) {

            bool result = false;
            for (int i = 0; i < boxCol.Count; i++) {
                Box box = boxCol[i];
                if (new BoxSameDimensions().Equals(box, item)) {
                    boxCol.RemoveAt(i);
                    Console.WriteLine($"Box with height : {item.height} | width : {item.width} | lenght : {item.lenght} Was removed");
                    result = true;
                    break;
                }
            }

            return result;

        }

        IEnumerator IEnumerable.GetEnumerator() {

            return new BoxEnumarator(this);

        }
    }

}
