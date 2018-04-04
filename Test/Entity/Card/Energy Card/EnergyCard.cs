using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class EnergyCard : Card
    {
        public EnergyCost[] Provides { get; private set; }

        public EnergyCard(Rarity rarity, string name, EnergyCost[] provides)
            : base(rarity, name)
        {
            this.Provides = provides;
        }
    }
}
