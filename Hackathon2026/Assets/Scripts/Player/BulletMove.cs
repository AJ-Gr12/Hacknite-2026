using UnityEngine;

public class BulletMove : MonoBehaviour
{
<<<<<<< Updated upstream
=======
<<<<<<< Updated upstream
    [SerializeField] float speed;
=======
>>>>>>> Stashed changes
    [SerializeField] float duration;
    public Transform laserFirePoint;
    public LineRenderer lr;
    Transform t;
>>>>>>> Stashed changes

    private void Awake()
    {
<<<<<<< Updated upstream
        Destroy(gameObject, 3);
=======
        t = GetComponent<Transform>();
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            RaycastHit2D hit = Physics2D.Raycast(t.position, t.right);
            Draw2DRay(t.position, hit.point);
        } else
        {
            Draw2DRay(t.position, t.transform.right * 100);
=======
            Destroy(collision.gameObject);
            Destroy(gameObject);
>>>>>>> Stashed changes
        }
    }
<<<<<<< Updated upstream
=======

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lr.SetPosition(0, startPos);
        lr.SetPosition(1, endPos);
    }
<<<<<<< Updated upstream
=======

    public void Clear2DRay()
    {
        lr.positionCount = 0;
    }
>>>>>>> Stashed changes
>>>>>>> Stashed changes
}
