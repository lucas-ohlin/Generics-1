using Labb1Generics.Modules;

namespace Labb1Generics {

    internal class Program {

        static void Main(string[] args) {

            BoxCollection boxes = new BoxCollection();
            boxes.Add(new Box(2, 3, 4));
            boxes.Add(new Box(3, 4, 5));
            boxes.Add(new Box(4, 5, 6));
            boxes.Add(new Box(5, 6, 7));
            boxes.Add(new Box(6, 7, 8));

            //The two boxes with the same dimensions
            boxes.Add(new Box(10, 10, 10));
            boxes.Add(new Box(10, 10, 10));

            DisplayData(boxes);

            //Remove one of the boxes
            boxes.Remove(new Box(6, 7, 8));

            DisplayData(boxes);

            Box boxCheck = new Box(2, 3, 4);
            Console.WriteLine($"Box with dimensions : h:{boxCheck.height}, w:{boxCheck.width}, l:{boxCheck.lenght} | exists : {boxes.Contains(boxCheck)}");

        }

        private static void DisplayData(BoxCollection boxes) {

            foreach (Box b in boxes) {
                Console.WriteLine($"Box | Height : {b.height}\tWidth : {b.width}\tLenght : {b.lenght} ");
            }

        }
          
    }

}