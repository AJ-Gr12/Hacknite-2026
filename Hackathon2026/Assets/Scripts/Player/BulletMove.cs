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

    private void OnDrawGizmos()
    {
        // 1. Save the original matrix so you don't corrupt other gizmos
        Matrix4x4 originalMatrix = Gizmos.matrix;

        // 2. Set the gizmo matrix to match the object's local-to-world transform
        Gizmos.matrix = transform.localToWorldMatrix;

        // 3. Draw your visual indicator (e.g., a wire cube or a directional ray)
        Gizmos.color = Color.cyan;
        
        // Notice we pass Vector3.zero as the center because the matrix defines the origin
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(1f, 1f, 2f)); 

        Gizmos.color = Color.red;
        // Draw a line pointing forward to explicitly show direction/rotation
        Gizmos.DrawLine(Vector3.zero, Vector3.forward * 2f);

        // 4. Reset the matrix back to default
        Gizmos.matrix = originalMatrix;
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
