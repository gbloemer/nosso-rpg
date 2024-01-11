using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public interface IBattleParticipant : IAttributes, IFinalAttributes
    {
        public IUser? User { get; }

        public ICharacter Character { get; }

        public long CurrentHp { get; set; }

        public long CurrentMp { get; set; }

        public int TurnOrder { get; set; }
    }
}
