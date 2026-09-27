using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private BulletMove bullet;
    void Start()
    {
        bullet = GetComponentInChildren<BulletMove>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; 


        Vector2 direction = mousePos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(0))
        {
            bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);

             bullet.ShootLaser();


        }
    }
}
