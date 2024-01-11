using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay.Impl
{
    public class BasicBattleParticipant : IBattleParticipant
    {
        public BasicBattleParticipant(ICharacter character, IUser? user)
        {
            this.Character = character;
            this.User = user;

            this.Character.CopyAttributes(this);
            this.Character.CopyFinalAttributes(this);
            this.CurrentHp = this.Character.Hp;
            this.CurrentMp = this.Character.Mp;
        }

        public ICharacter Character { get; }

        public IUser? User { get; }

        public long CurrentHp { get; set; }
        
        public long CurrentMp { get; set; }

        public int TurnOrder { get; set; }

        public int Dexterity { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public long Hp { get; set; }

        public long Mp { get; set; }

        public long Attack { get; set; }

        public long Defense { get; set; }
    }
}
