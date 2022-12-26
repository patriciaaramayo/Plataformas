using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    public Vector3 direction = new Vector3(5,0, 0);
    public float damage;

    void Start()
    {

    }


    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
