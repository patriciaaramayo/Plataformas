using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonEnemy : Enemy
{
    public GameObject bulletToInstantiate;
    public Transform turret;
    public float tiempoRestante = 5f;
    private float resetTimer;

    void Start()
    {
        resetTimer = tiempoRestante;
    }
    private void Update()
    {
        tiempoRestante -= Time.deltaTime;
        if (tiempoRestante <= 0)
        {
            BasicAttack();
            tiempoRestante = resetTimer;
        }

    }
    public override void BasicAttack()
    {
        base.BasicAttack();
        Instantiate(bulletToInstantiate, turret.position, turret.rotation);


    }
}
