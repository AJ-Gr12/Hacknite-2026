using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bug")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
