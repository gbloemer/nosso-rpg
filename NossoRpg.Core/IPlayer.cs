using NossoRpg.Core.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core
{
    public interface IPlayer
    {
        public IUser User { get; }

        public ICharacter Character { get; set; }
    }
}
