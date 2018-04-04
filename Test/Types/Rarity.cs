using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language;

namespace Types
{
    public class Rarity : IComparable<Rarity>
    {
        // Order matters (to compare)
        public enum Rarities { Common, Uncommon, Rare, HolofoilRare };

        public Rarities Type { get; private set; }

        public Rarity(Rarities type)
        {
            this.Type = type;
        }

        public int CompareTo(Rarity other)
        {
            return (int)this.Type - (int)other.Type;
        }

        public override string ToString()
        {
            string ret = string.Empty;

            switch(this.Type)
            {
                case Rarities.Common:
                    ret = Literals.rm.GetString("RarityCommon");
                    break;
                case Rarities.Uncommon:
                    ret = Literals.rm.GetString("RarityUncommon");
                    break;
                case Rarities.Rare:
                    ret = Literals.rm.GetString("RarityRare");
                    break;
                case Rarities.HolofoilRare:
                    ret = Literals.rm.GetString("RarityHolofoilRare");
                    break;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return this.Type.GetHashCode();
        }
    }
}
