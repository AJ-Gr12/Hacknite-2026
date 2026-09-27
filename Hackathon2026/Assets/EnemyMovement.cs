using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f;
    public float chaseRadius = 5f;

    private Transform playerTransform;
    private Rigidbody2D rb;

    void start()
    {
        rb = GetComponent<Rigidbody2D>();

        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
    }

    void update()
    {
        if (playerTransform == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, playerTransform.position);

        if (distanceToPlayer <= chaseRadius)
        {
            MoveTowardsPlayer();
        } else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }

    void MoveTowardsPlayer()
    {
        Vector2 direction = (playerTransform.position - transform.position).normalized;

        rb.linearVelocity = direction * speed;

        if (direction.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (direction.x < 0) {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
