using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public string enemyName;
    public string velocity;
    public int damage;

    public virtual void BasicAttack()
    {
        Debug.Log("BASIC ATTACK");
    }

}
