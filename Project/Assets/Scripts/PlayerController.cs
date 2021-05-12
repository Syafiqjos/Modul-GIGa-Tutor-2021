using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 1.0f;
    [SerializeField] private float jumpForce = 2.0f;

    private Rigidbody2D rb2;
    private bool isGrounded = true;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementController();
        JumpController();
        ShootController();
    }

    void MovementController()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector2 direction = rb2.velocity;
        direction.x = x * moveSpeed;

        rb2.velocity = direction;

        //sprite dibalik ketika arahnya ke kiri
        if (direction.x < 0)
        {
            graphic.flipX = true;
        } else if (direction.x > 0)
        {
            graphic.flipX = false;
        }
    }

    void JumpController()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            rb2.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void ShootController()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();
        }
    }

    void Shoot()
    {

    }
}
