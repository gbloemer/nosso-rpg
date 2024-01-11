using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public interface ICharacter : IAttributes, IFinalAttributes
    {
        public string Name { get; }

        public int Level { get; set; }
    }

    public interface IAttributes
    {
        public int Dexterity { get; set; }
        
        public int Strength { get; set; }

        public int Agility { get; set; }
    }

    public interface IFinalAttributes
    {

        public long Hp { get; set; }

        public long Mp { get; set; }

        public long Attack { get; set; }

        public long Defense { get; set; }
    }
}
