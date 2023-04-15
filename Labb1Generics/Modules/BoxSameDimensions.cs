using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics.Modules {

    internal class BoxSameDimensions : EqualityComparer<Box> {

        public override bool Equals(Box? x, Box? y) {

            if (x.height == y.height && x.width == y.width && x.lenght == y.lenght) {
                return true;
            }
            else {
                return false;
            }

        }

        public override int GetHashCode([DisallowNull] Box obj) {
            
            var hCode = obj.height ^ obj.width ^ obj.lenght;
            return hCode.GetHashCode();

        }
    }

}
