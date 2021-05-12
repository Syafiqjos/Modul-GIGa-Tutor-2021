using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    [Header("Properties")]
    [SerializeField] private SpriteRenderer graphic;

    [Header("Status")]
    [SerializeField] private float health = 100;
    [SerializeField] private float attack = 5;

    private bool isGrounded = true;
    private bool isShooting = true;
    private int velocityX = 0;
    private int velocityY = 0;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float dashDistance = 2.0f;

    [SerializeField] private float minGroundDistance = 1.5f;

    private Rigidbody2D rb2;
    private Animator animator;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        MovementController();
        JumpController();
        DashController();
        ShootController();

        AnimationController();
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
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, 10, (1 << 3));
        
        if (ray && ray.distance < minGroundDistance)
        {
            isGrounded = true;
        } else
        {
            isGrounded = false;
        }

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
        isShooting = false;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        isShooting = true;
    }

    public void DamagedBy(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    void Die()
    {
        GameManager.Instance.GameOver();
    }

    void AnimationController()
    {
        velocityX = (int)Mathf.Clamp(rb2.velocity.x, -1, 1);
        velocityY = (int)Mathf.Clamp(rb2.velocity.y, -1, 1);

        animator.SetBool("isShooting", isShooting);
        animator.SetBool("isGrounded", isGrounded);
        animator.SetInteger("velocityX", velocityX);
        animator.SetInteger("velocityY", velocityY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            float damage = collision.collider.GetComponent<EnemyController>().GetAttackDamage();
            DamagedBy(damage);
        } else if (collision.collider.tag == "Bullet")
        {
            float damage = collision.collider.GetComponent<Bullet>().GetDamage();
            DamagedBy(damage);
        }
    }
}
