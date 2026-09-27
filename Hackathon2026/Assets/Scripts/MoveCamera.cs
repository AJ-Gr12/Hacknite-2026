using NUnit.Framework;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] float smoothSpeed;


    void Start()
    {
        
    }


    void Update()
    {
        Vector3 targetPos = player.position;

        transform.position = Vector3.Lerp(transform.position, targetPos, smoothSpeed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, transform.position.y, -10);
    }
}
