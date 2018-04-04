using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class TrainerCard : Card
    {
        public string Description { get; private set; }

        public TrainerCard(string name, Rarity rarity, string description) : base(rarity, name)
        {
            this.Description = description;
        }
    }
}
