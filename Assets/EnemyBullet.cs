using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public float damageAmount = 10f;

    private Rigidbody2D rb;
    private void start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (player != null)
            {
                player.Damage(damageAmount);
                // GameObject particles = Instantiate(hitParticlesPrefab, transform.position, transform.rotation);
                // Destroy(particles, 5f);
                Destroy(this.gameObject);
            }
        }
    }
    
}
