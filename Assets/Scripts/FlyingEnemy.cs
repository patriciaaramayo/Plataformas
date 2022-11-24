using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemy
{
    public override void BasicAttack()
    {
        base.BasicAttack();
        Debug.Log("FlyingEnemy Attack");
    }

}
