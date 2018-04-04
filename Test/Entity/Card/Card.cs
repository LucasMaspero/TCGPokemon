using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class Card
    {
        public Rarity Rarity { get; private set; }
        public string Name { get; private set; }

        public Card(Rarity rarity, string name)
        {
            this.Rarity = rarity;
            this.Name = name;
        }
    }
}
