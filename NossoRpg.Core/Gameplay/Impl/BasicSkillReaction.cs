using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay.Impl
{
    public class BasicSkillReaction : ISkillReaction
    {
        public string Event { get; set; }

        public string Script { get; set;}
    }
}
