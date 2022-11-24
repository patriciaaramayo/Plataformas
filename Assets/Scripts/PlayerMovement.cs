using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;
    public Animator anim;

    [SerializeField] AudioSource enemyDieSound;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputJugador = new Vector3(horizontalInput,0,verticalInput);
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetKey("space") && IsGrounded())
        {
            Jump();
        }
        if (Input.GetKeyUp("space"))
            {
            anim.SetBool("isJumping", false);
        }
        if (inputJugador == Vector3.zero)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    void Jump()
    {
        anim.SetBool("isJumping", true);
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        jumpSound.Play();     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Debug.Log("OnCollisionEnter");
            enemyDieSound.Play();
            Destroy(collision.transform.parent.gameObject);
        }
    }

    bool IsGrounded()
    {

        return Physics.CheckSphere(groundCheck.position, .10f, ground);
    }
}