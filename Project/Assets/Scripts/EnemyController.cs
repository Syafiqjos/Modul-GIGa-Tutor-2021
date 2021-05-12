using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Status")]
    [SerializeField] private float health = 20;
    [SerializeField] private float attack = 5;

    [SerializeField] private Transform attackTarget;

    [Header("Configuration")]
    [SerializeField] private float moveSpeed = 2.5f;    

    void Update()
    {
        Movement();
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

    void Die()
    {
        Destroy(gameObject);
    }

    public float GetAttackDamage()
    {
        return attack;
    }
}
