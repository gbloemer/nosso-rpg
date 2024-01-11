using NossoRpg.Core.Gameplay;
using NossoRpg.Core.Gameplay.Impl;

namespace NossoRpg.Core.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        IBattle battle = new BasicBattle();
        ICharacter[] chars = new ICharacter[] {
            new BasicCharacter("Eu", 100) { Hp = 1000, Mp = 1000, Attack = 100 },
            new BasicCharacter("Inimigo", 50) { Hp = 500, Mp = 500, Defense = 50 },
        };
        IBattleParticipant[] part = new IBattleParticipant[] {
            new BasicBattleParticipant(chars[0], null),
            new BasicBattleParticipant(chars[1], null)
        };
        battle.Participants.Add(part[0]);
        battle.Participants.Add(part[1]);
        Assert.Equal(BattleState.Preparing, battle.CurrentState);

        battle.StartBattle();
        Assert.Equal(BattleState.WaitingAction, battle.CurrentState);

        battle.UseSkillOnTargets(part[0], new BasicSkill("Fireball"), part[1]);
        Assert.Equal(2, battle.CurrentTurn);
        Assert.Equal(450, part[1].CurrentHp);
    }
}