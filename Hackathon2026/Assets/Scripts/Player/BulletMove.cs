using UnityEngine;

public class BulletMove : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] float speed;
=======
    [SerializeField] float duration;
    [SerializeField] ParticleSystem psStart;
    [SerializeField] ParticleSystem psEnd;
    public Transform laserFirePoint;
    public LineRenderer lr;
    Transform t;
>>>>>>> Stashed changes

    void Start()
    {
<<<<<<< Updated upstream
        Destroy(gameObject, 3);
=======
        t = GetComponent<Transform>();
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
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
<<<<<<< Updated upstream
=======

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lr.positionCount = 2;
        lr.SetPosition(0, startPos);
        lr.SetPosition(1, endPos);
        psEnd.transform.position = new Vector3 (endPos[0], endPos[1], 0);
    }

    public void Clear2DRay()
    {
        lr.positionCount = 0;
    }
>>>>>>> Stashed changes
}
