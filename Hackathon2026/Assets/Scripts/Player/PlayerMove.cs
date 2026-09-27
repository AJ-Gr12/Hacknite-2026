using UnityEngine;

public class PlayerMove : MonoBehaviour
{
     float speed;
    Vector2 direction;
    Rigidbody2D rb;
    SpriteRenderer sr;
    PlayerStats stats;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        speed = stats.moveSpeed;

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += new Vector2(0, 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += new Vector2(0, -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += new Vector2(-1, 0);
            sr.flipX = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(1, 0);
            sr.flipX = false;
        }

        direction = direction.normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direction * speed;
    }
}