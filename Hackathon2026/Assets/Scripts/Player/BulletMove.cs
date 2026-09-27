using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float duration;
    public Transform laserFirePoint;
    public LineRenderer lr;
    Transform t;

    private void Awake()
    {
        t = GetComponent<Transform>();

    }

    public void ShootLaser()
    {
        if (Physics2D.Raycast(t.position, transform.right))
        {
            RaycastHit2D hit = Physics2D.Raycast(t.position, t.right);
            Draw2DRay(t.position, hit.point);
        } else
        {
            Draw2DRay(t.position, t.transform.right * 100);
        }
    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lr.SetPosition(0, startPos);
        lr.SetPosition(1, endPos);
    }
}
