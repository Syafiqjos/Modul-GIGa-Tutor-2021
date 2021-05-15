using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Status")]
    public float health = 20;
    public float attack = 5;

    public Transform attackTarget;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;

    void Update()
    {
        Movement();

        FallDie();
    }

    protected virtual void Movement()
    {

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

    void FallDie()
    {
        if (transform.position.y < -20)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        ScoreManager.DefeatEnemy();
    }

    public float GetAttackDamage()
    {
        return attack;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Bullet bullet = collision.GetComponent<Bullet>();
            if (bullet.targetTag == "Enemy")
            {
                float damage = bullet.GetDamage();
                DamagedBy(damage);
                Destroy(collision.gameObject);
            }
        }
    }
}
