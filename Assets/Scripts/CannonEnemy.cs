using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonEnemy : Enemy
{
    public override void BasicAttack()
    {
        base.BasicAttack();
        Debug.Log("CannonEnemy Attack");

        
    }
}
