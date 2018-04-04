using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language;

namespace Types
{
    public class TCGType
    {
        public enum TCGTypes { Grass, Fire, Water, Lighting, Fighting, Psychic, Colorless, Darkness, Metal, Dragon, Fairy };

        public TCGTypes Type { get; private set; }

        public TCGType(TCGTypes type)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            string ret = string.Empty;

            switch (this.Type)
            {
                case TCGTypes.Grass:
                    ret = Literals.rm.GetString("TCGTypeGrass");
                    break;
                case TCGTypes.Fire:
                    ret = Literals.rm.GetString("TCGTypeFire");
                    break;
                case TCGTypes.Water:
                    ret = Literals.rm.GetString("TCGTypeWater");
                    break;
                case TCGTypes.Lighting:
                    ret = Literals.rm.GetString("TCGTypeLighting");
                    break;
                case TCGTypes.Fighting:
                    ret = Literals.rm.GetString("TCGTypeFighting");
                    break;
                case TCGTypes.Psychic:
                    ret = Literals.rm.GetString("TCGTypePsychic");
                    break;
                case TCGTypes.Colorless:
                    ret = Literals.rm.GetString("TCGTypeColorless");
                    break;
                case TCGTypes.Darkness:
                    ret = Literals.rm.GetString("TCGTypeDarkness");
                    break;
                case TCGTypes.Metal:
                    ret = Literals.rm.GetString("TCGTypeMetal");
                    break;
                case TCGTypes.Dragon:
                    ret = Literals.rm.GetString("TCGTypeDragon");
                    break;
                case TCGTypes.Fairy:
                    ret = Literals.rm.GetString("TCGTypeFairy");
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
