using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float maxTime = 0f;
    public float time;
    public int ammo;
    public float moveSpeed;
    public float cooldown = 0.5f;

    void setMaxTime(int min, int sec)
    {
        maxTime += min * 60;
        maxTime += sec;
    }
}
