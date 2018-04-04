using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language;

namespace Types
{
    public class HP
    {
        public int Value { get; private set; }

        public HP(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value + " " + Literals.rm.GetString("HP");
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }
    }
}
