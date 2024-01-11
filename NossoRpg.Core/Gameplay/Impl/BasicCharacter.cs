using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay.Impl
{
    public class BasicCharacter : ICharacter
    {
        public BasicCharacter(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name { get; internal set; }

        public int Level { get; set; }

        public int Dexterity { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public long Hp { get; set; }

        public long Mp { get; set; }

        public long Attack { get; set; }

        public long Defense { get; set; }
    }
}
