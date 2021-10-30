using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType1 : Enemy
{
    float armorRatio = 0.5f;

    public override void TakeDamage(float damage)
    {
        enemyHP -= damage * armorRatio;
        LifeCheck();
    }

}
