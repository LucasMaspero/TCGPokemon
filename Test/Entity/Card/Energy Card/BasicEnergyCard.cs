using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using Language;

namespace Entity
{
    public class BasicEnergyCard : EnergyCard
    {
        public BasicEnergyCard(TCGType type)
            : base(
                  new Rarity(Rarity.Rarities.Common), 
                  type.ToString() + " " + Literals.rm.GetString("Energy"), 
                  new EnergyCost[] { new EnergyCost(type) }) { }
    }
}
