using Unity.VisualScripting;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static float maxTime = 10f;
    public static float time;
    public static int ammo;
    public static float moveSpeed;
    public static float cooldown = 2f;
    public static float duration = 0.5f;

    void Start()
    {
        maxTime = 10 + 10 * ShopUpgrades.timeUpgrades;

        time = maxTime;
    }

    public static void SetMaxTime(int min, int sec)
    {
        maxTime += min * 60;
        maxTime += sec;
        time = maxTime;
    }
    
    public static void AddTime(float amount)
    {
        time += amount;
    }

    void Update()
    {
        moveSpeed = 3 + (ShopUpgrades.speedUpgrades * 2);
    }
    
    public static float GetMaxTime()
    {
        maxTime = 10 + 10 * ShopUpgrades.timeUpgrades;
        return maxTime;
    }
}
