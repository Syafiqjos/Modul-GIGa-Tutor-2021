using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float damage = 2;
    [SerializeField] private float dieTime = 5;

    private Vector2 direction;

    private Rigidbody2D rb2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb2.velocity = direction.normalized * speed;

        dieTime -= Time.deltaTime;

        if (dieTime < 0)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float speed)
    {
        this.direction = direction;
        this.speed = speed;
    }

    public float GetDamage()
    {
        return damage;
    }
}
