using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private BulletMove bullet;
    private float cooldown = 0f;
    private float duration = 0f;
    [SerializeField] private ParticleSystem psStart;
    [SerializeField] private ParticleSystem psEnd;
    void Start()
    {
        bullet = GetComponentInChildren<BulletMove>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Math.Abs(Camera.main.transform.position.z - transform.position.z);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        mousePos.z = 0f; 

        Vector2 direction = mousePos - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(0) && cooldown <= 0f)
        {
            cooldown = PlayerStats.cooldown;
            duration = PlayerStats.duration;

            ParticleSystem.MainModule main = psStart.main;
            main.duration = PlayerStats.duration;
            main = psEnd.main;
            main.duration = PlayerStats.duration;
            psStart.Play();
            psEnd.Play();
        }
        
        if (duration > 0)
        {
            bullet.transform.rotation = Quaternion.Euler(0f, 0f, angle);

            bullet.ShootLaser();

            duration -= 1 * Time.deltaTime;
        } else
        {
            bullet.Clear2DRay();
            if (cooldown > 0)
            {
                cooldown -= 1 * Time.deltaTime;
            }
        }
    }
}
