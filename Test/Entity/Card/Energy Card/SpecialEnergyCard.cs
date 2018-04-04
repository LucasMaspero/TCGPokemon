using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class SpecialEnergyCard : EnergyCard
    {
        public SpecialEnergyCard(EnergyCost[] provides, string name)
            : base(
                  new Rarity(Rarity.Rarities.Common), 
                  name, 
                  provides) { }
    }
}
