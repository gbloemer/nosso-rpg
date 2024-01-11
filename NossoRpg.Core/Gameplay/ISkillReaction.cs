using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public interface ISkillReaction
    {
        public string Event { get; }
        public string Script { get; }
    }
}
