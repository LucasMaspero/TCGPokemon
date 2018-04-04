using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language;

namespace Types
{
    public class PokemonForce
    {
        public enum Forces { Normal, Light, Dark };

        public Forces Type { get; private set; }

        public PokemonForce(Forces type)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            string ret = string.Empty;

            switch (this.Type)
            {
                case Forces.Normal:
                    ret = Literals.rm.GetString("TCGPokemonForceNormal");
                    break;
                case Forces.Dark:
                    ret = Literals.rm.GetString("TCGPokemonForceDark");
                    break;
                case Forces.Light:
                    ret = Literals.rm.GetString("TCGPokemonForceLight");
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
