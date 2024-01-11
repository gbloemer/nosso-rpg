using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public interface ISkill
    {
        public string Name { get; }

        public string? Description { get; set; }

        public string? DamageFormula { get; set; }

        public string? CostFormula { get; set; }
    }
}
