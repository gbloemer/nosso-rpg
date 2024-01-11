using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NossoRpg.Core.Gameplay.Impl
{
    public class BasicBattle : IBattle
    {
        public BasicBattle()
        {
            this.Participants = new List<IBattleParticipant>();
            this.Reactions = new List<IBattleReaction>();
            this.LogHistory = new List<string>();
            this.CurrentState = BattleState.Preparing;
        }

        public List<IBattleParticipant> Participants { get; }

        public List<IBattleReaction> Reactions { get; }

        public List<string> LogHistory { get; }

        public BattleState CurrentState { get; private set; }

        public int CurrentTurn { get; private set; }

        public void AddLog(string message)
        {
            this.LogHistory.Add(message);
        }

        public void StartBattle()
        {
            // TODO: Compute initiative

            this.CurrentTurn = 1;
            this.CurrentState = BattleState.WaitingAction;
        }

        public void UseSkillOnTargets(IBattleParticipant user, ISkill skill, params IBattleParticipant[] targets)
        {
            foreach(IBattleParticipant target in targets)
            {
                if (target == null) continue;

                long damage = user.Attack - target.Defense;
                target.CurrentHp -= damage;
                this.AddLog($"{user.Character.Name} dealt {damage} to {target.Character.Name}");
            }
            
            this.NextTurn();
        }

        public void Move(IBattleParticipant user)
        {
            this.AddLog($"{user.Character.Name} moved to ...");
            this.NextTurn();
        }

        public void SkipTurn(IBattleParticipant user)
        {
            this.AddLog($"{user.Character.Name} skipped the turn");
            this.NextTurn();
        }

        public void NextTurn()
        {
            this.CurrentTurn++;
            // TODO: Next Turn events
        }
    }
}
