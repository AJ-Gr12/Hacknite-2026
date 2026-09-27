using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rb;
    SpriteRenderer sr;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector2 direction = Vector2.zero;

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

        rb.linearVelocity = direction * speed;
    }
}
