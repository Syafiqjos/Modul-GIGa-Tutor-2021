using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    public float damage = 2;
    public Vector2 direction;

    public float dieTime = 5;

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

    public void Launch(Vector2 direction, int speed)
    {
        this.direction = direction;
        this.speed = speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerController>().DamagedBy(damage);
            Destroy(gameObject);
        } else if (other.tag == "Enemy") {
            other.GetComponent<EnemyController>().DamagedBy(damage);
            Destroy(gameObject);
        }
    }
}
