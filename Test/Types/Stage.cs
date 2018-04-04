using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Language;

namespace Types
{
    public class Stage : IComparable<Stage>
    {
        public enum Stages { Basic, Fase1, Fase2 };

        public Stages Type { get; private set; }

        public Stage(Stages type)
        {
            this.Type = type;
        }

        public int CompareTo(Stage other)
        {
            return (int)this.Type - (int)other.Type;
        }

        public override string ToString()
        {
            string ret = string.Empty;

            switch (this.Type)
            {
                case Stages.Basic:
                    ret = Literals.rm.GetString("StageBasic");
                    break;
                case Stages.Fase1:
                    ret = Literals.rm.GetString("StageFase1");
                    break;
                case Stages.Fase2:
                    ret = Literals.rm.GetString("StageFase2");
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
