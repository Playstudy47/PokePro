
using UnityEngine;

public class BattleManager
{
    public int damageCalculate(CardEffect effect, MonsterCard attackingMonster , MonsterCard attackedMonster)
    {
        int damage = 100;
        if(damage != 0)
        {

            if(attackingMonster.type.Equals(attackedMonster.resistance))
            {
                damage -= 30;
            }


            if(attackingMonster.type.Equals(attackedMonster.weakness))
            {
                damage *= 2;
            }
        }
        return damage;
    }

}
