using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NossoRpg.Core.Gameplay.Impl
{
    public class BasicSkill : ISkill
    {
        public BasicSkill(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string? DamageFormula { get; set; }

        public string? CostFormula { get; set; }
    }
}
