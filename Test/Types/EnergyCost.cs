using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class EnergyCost
    {
        public TCGType Type { get; private set; }

        public EnergyCost(TCGType type)
        {
            this.Type = type;
        }

        public override int GetHashCode()
        {
            return this.Type.GetHashCode();
        }
    }
}
