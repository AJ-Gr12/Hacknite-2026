using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField] GameObject bulletInstance;
    void Start()
    {
        
=======
    private BulletMove bullet;
    private PlayerStats stats;
    private float cooldown = 0f;
    [SerializeField] private ParticleSystem psStart;
    [SerializeField] private ParticleSystem psEnd;
    void Start()
    {
        bullet = GetComponentInChildren<BulletMove>();
        stats = GetComponentInChildren<PlayerStats>();
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; 


        Vector2 direction = mousePos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(0) && cooldown <= 0)
        {
            ParticleSystem.MainModule main = psStart.main;
            main.duration = stats.cooldown;
            main = psEnd.main;
            main.duration = stats.cooldown;
            psStart.Play();
            psEnd.Play();

            cooldown = stats.cooldown;
        }
        
        if (cooldown > 0)
        {
            GameObject bullet = Instantiate(bulletInstance);

            bullet.transform.position = transform.position;

            bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);

<<<<<<< Updated upstream
=======
            bullet.ShootLaser();

            cooldown -= 1 * Time.deltaTime;
        } else
        {
            bullet.Clear2DRay();
>>>>>>> Stashed changes
        }
    }
}
