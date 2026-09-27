using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] ParticleSystem psStart;
    [SerializeField] ParticleSystem psEnd;
    public Transform laserFirePoint;
    public LineRenderer lr;
    Transform t;

    void Start()
    {
        t = GetComponent<Transform>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bug")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

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
}
