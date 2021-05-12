using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    [SerializeField] private float health;
    [SerializeField] private float attack;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float dashDistance = 2.0f;

    private Rigidbody2D rb2;
    private bool isGrounded = true;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementController();
        JumpController();
        DashController();
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

    void DashController()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Dash();
        }
    }

    void Dash()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector2 newPos = rb2.position + new Vector2(dashDistance * direction, 0);

        rb2.MovePosition(newPos);
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

    public void DamagedBy(int delta)
    {
        health -= delta;
        if (health <= 0)
        {
            health = 0;
            GameManager.Instance.GameOver();
        }
    }
}
