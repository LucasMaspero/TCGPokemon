using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Resistance
    {
        public TCGType Type { get; private set; }
        public int Decreaser { get; private set; }

        public Resistance(TCGType type)
        {
            this.Type = type;
            this.Decreaser = 30; // -30
        }

        public Resistance(TCGType type, int decreaser)
        {
            this.Type = type;
            this.Decreaser = decreaser;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Type, this.Decreaser).GetHashCode();
        }
    }
}
