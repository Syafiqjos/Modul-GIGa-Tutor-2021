using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMushroom : EnemyController
{
    [Header("Mushroom")]
    [SerializeField] SpriteRenderer graphic;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;

    [SerializeField] private float attackMinDistance;
    [SerializeField] private float attackTimeMax;

    [SerializeField] private Vector3 shootOffset;
    private float attackTime = 0;

    protected override void Movement()
    {
        if (attackTarget)
        {
            float distance = Vector2.Distance(transform.position, attackTarget.position);
            if (distance < attackMinDistance)
            {
                if (attackTarget.position.x < transform.position.x)
                {
                    graphic.flipX = true;
                } else
                {
                    graphic.flipX = false;
                }

                if (attackTime < 0)
                {
                    Shoot();
                    attackTime = attackTimeMax;
                }

                attackTime -= Time.deltaTime;
            }
        }
    }

    void Shoot()
    {
        int direction = (graphic.flipX == false ? 1 : -1);

        Vector3 shootOffsetDirection = shootOffset;

        if (direction < 0)
        {
            shootOffsetDirection.x *= -1;
        }

        Vector3 shootPos = transform.position + shootOffsetDirection;

        GameObject bulletObj = Instantiate(bulletPrefab, shootPos, Quaternion.identity);
        Bullet bullet = bulletObj.GetComponent<Bullet>();
        bullet.Launch(new Vector2(direction, 0), "Player", bulletSpeed, attack);
    }
}
