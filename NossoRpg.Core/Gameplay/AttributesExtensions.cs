using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public static class AttributesExtensions
    {
        public static void CopyAttributes(this IAttributes refThis, IAttributes target)
        {
            target.Dexterity = refThis.Dexterity;
            target.Strength = refThis.Strength;
            target.Agility = refThis.Agility;
        }

        public static void CopyFinalAttributes(this IFinalAttributes refThis, IFinalAttributes target)
        {
            target.Hp = refThis.Hp;
            target.Mp = refThis.Mp;
            target.Defense = refThis.Defense;
            target.Attack = refThis.Attack;
        }
    }
}
