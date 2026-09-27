using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(1, 0);
        }

        rb.linearVelocity = direction * speed;
    }
}
