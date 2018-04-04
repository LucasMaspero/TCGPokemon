using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public class TCGPokemonMove
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public EnergyCost[] Cost { get; private set; }
        public int Damage { get; private set; }

        public TCGPokemonMove(string name, string description, EnergyCost[] cost, int damage)
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;
            this.Damage = damage;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Name, this.Description, this.Cost, this.Damage).GetHashCode();
        }
    }
}
