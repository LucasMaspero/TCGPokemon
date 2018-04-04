using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Weakness
    {
        public TCGType Type { get; private set; }
        public int Multiplier { get; private set; }

        public Weakness(TCGType type)
        {
            this.Type = type;
            this.Multiplier = 2; // x2
        }

        public Weakness(TCGType type, int multiplier)
        {
            this.Type = type;
            this.Multiplier = multiplier;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Type, this.Multiplier).GetHashCode();
        }
    }
}
