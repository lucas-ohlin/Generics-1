using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics.Modules {

    internal class BoxEnumarator : IEnumerator<Box> {

        private BoxCollection _box;
        private int _index;
        private Box _boxindex;

        public BoxEnumarator(BoxCollection box) {
            this._box = box;
            _index = -1;
            _boxindex = default(Box);
        }

        public Box Current { get { return _boxindex; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose() {

        }

        public bool MoveNext() {

            if (++_index >= _box.Count)
                return false;
            else
                _boxindex = _box[_index];

            return true;
        }

        public void Reset() {
            _index -= 1;
        }

    }

}
