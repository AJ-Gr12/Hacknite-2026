using Unity.VisualScripting;
using UnityEngine;

public class ShopUpgrades : MonoBehaviour
{
    public static int hacks;
    public static int ammoUpgrades;
    public static int timeUpgrades;
    public static int speedUpgrades;

    private static GameObject instance;

    void Awake()
    {
        if (instance != null && instance != gameObject)
        {
            Destroy(gameObject);
            return;
        }

        instance = gameObject;
        DontDestroyOnLoad(gameObject);
    }



    void Start()
    {
        ammoUpgrades = 0;
        timeUpgrades = 0;
        speedUpgrades = 0;

        hacks = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
