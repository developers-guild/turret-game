using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRigidBody;
    public float movementSpeed;
    public float jumpForce;

    private bool isJumping;
    private bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);

        Flip(horizontal);

        Jump();
    }

    private void HandleMovement(float horizontal)
    {
        playerRigidBody.velocity = new Vector2(horizontal * movementSpeed, playerRigidBody.velocity.y);
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            playerRigidBody.AddForce(new Vector2(playerRigidBody.velocity.x, jumpForce)); 
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            playerRigidBody.velocity = Vector2.zero;
        }
    }
}
