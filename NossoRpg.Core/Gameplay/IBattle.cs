using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossoRpg.Core.Gameplay
{
    public interface IBattle
    {
        public List<IBattleParticipant> Participants { get; }

        public List<IBattleReaction> Reactions { get; }

        public BattleState CurrentState { get; }

        public int CurrentTurn { get; }

        public void StartBattle();

        public void AddLog(string message);
        
        public void UseSkillOnTargets(IBattleParticipant user, ISkill skill, params IBattleParticipant[] target);

        public void Move(IBattleParticipant user);
        
        public void SkipTurn(IBattleParticipant user);
    }

    public enum BattleState
    {
        Preparing, WaitingAction, WaitingReaction, Finished
    }

    public interface IBattleReaction
    {
        public ISkillReaction Reaction { get; }

        public bool Active { get; set; }

        public bool Ask { get; set; }
    }
}
