using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float maxTime = 0f;
    public float time;
    public int ammo;
    public float moveSpeed;
    public float cooldown = 0.5f;

    void Start()
    {
        time = maxTime;
    }

    public void SetMaxTime(int min, int sec)
    {
        maxTime += min * 60;
        maxTime += sec;
        time = maxTime;
    }
    
    public void AddTime(float amount)
    {
        time += amount;
    }

    
}
