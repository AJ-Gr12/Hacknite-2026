using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float maxTime = 0f;
    public static float time;
    public static int ammo;
    public static float moveSpeed;

    void setMaxTime(int min, int sec)
    {
        maxTime += min * 60;
        maxTime += sec;
    }

    void Start()
    {

    }
}
