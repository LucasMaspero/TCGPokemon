using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class Trainer
    {
        public string Name { get; private set; }

        public Trainer(string name)
        {
            this.Name = name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
