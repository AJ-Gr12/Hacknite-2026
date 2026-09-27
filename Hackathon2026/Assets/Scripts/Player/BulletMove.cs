using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] ParticleSystem psStart;
    [SerializeField] ParticleSystem psEnd;
    public Transform laserFirePoint;
    public LineRenderer lr;
    Transform t;

    void Start()
    {
        t = GetComponent<Transform>();

    }

    public void ShootLaser()
    {
        if (Physics2D.Raycast(t.position, transform.right))
        {
            RaycastHit2D hit = Physics2D.Raycast(t.position, transform.right);
            Draw2DRay(t.position, hit.point);
            Destroy(hit.collider.gameObject);
        } else
        {
            Draw2DRay(t.position, t.position + (t.right * 20));
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
