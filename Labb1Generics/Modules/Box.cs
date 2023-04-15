using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics.Modules {

    //IEquatable, method for determening equality of instances
    internal class Box : IEquatable<Box> {

        public int height { get; set; }
        public int lenght { get; set; }
        public int width { get; set; }

        public Box(int height, int lenght, int width) {
            this.height = height;
            this.lenght = lenght;
            this.width = width;
        }

        public bool Equals(Box? other) {

            if (new BoxSameDimensions().Equals(this, other)) {
                return true;
            } else {
                return false;
            }

        }

        public override bool Equals(object? obj) {
            return base.Equals(obj);    
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

    }

}
