using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hackCount;
    [Space]
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI ammoText;
    [SerializeField] TextMeshProUGUI timeText;
    [Space]
    [SerializeField] TextMeshProUGUI speedPriceText;
    [SerializeField] TextMeshProUGUI ammoPriceText;
    [SerializeField] TextMeshProUGUI timePriceText;

    [Space]
    [SerializeField] GameObject timeButton;
    [SerializeField] GameObject ammoButton;
    [SerializeField] GameObject speedButton;



    int speedPrice;
    int ammoPrice;
    int timePrice;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed " + UpgradeCount(ShopUpgrades.speedUpgrades, 5);
        ammoText.text = "Ammo  " + UpgradeCount(ShopUpgrades.ammoUpgrades, 5);
        timeText.text = "Time  " + UpgradeCount(ShopUpgrades.timeUpgrades, 5);

        speedPrice = 5 + 5 * ShopUpgrades.speedUpgrades;
        timePrice = 5 + 5 * ShopUpgrades.timeUpgrades;
        ammoPrice = 5 + 5 * ShopUpgrades.ammoUpgrades;

        
        if(ShopUpgrades.timeUpgrades < 5) timePriceText.text = timePrice + " HackCoin";
        if (ShopUpgrades.ammoUpgrades < 5) ammoPriceText.text = ammoPrice + " HackCoin";
        if (ShopUpgrades.speedUpgrades < 5) speedPriceText.text = speedPrice + " HackCoin";

        hackCount.text = "HackCoin: " + ShopUpgrades.hacks;

        
    }


    string UpgradeCount(int count, int max)
    {
        string text = "[";
        for(int i = 0; i < count; i++)
        {
            text += "+ ";
        }

        for (int i = 0; i < max - count; i++)
        {
            text += "- ";
        }
        text += "]";

        return text;
    }





    public void TimeUpgrade()
    {
        if (ShopUpgrades.hacks < timePrice) return;

        ShopUpgrades.hacks -= timePrice;

        ShopUpgrades.timeUpgrades++;
        if (ShopUpgrades.timeUpgrades >= 5)
        {
            timeButton.SetActive(false);
            timePriceText.text = "";
        }
    }

    public void AmmoUpgrade()
    {
        if (ShopUpgrades.hacks < ammoPrice) return;

        ShopUpgrades.hacks -= ammoPrice;

        ShopUpgrades.ammoUpgrades++;
        if (ShopUpgrades.ammoUpgrades >= 5)
        {
            ammoButton.SetActive(false);
            ammoPriceText.text = "";
        }
    }

    public void SpeedUpgrade()
    {
        if (ShopUpgrades.hacks < speedPrice) return;

        ShopUpgrades.hacks -= speedPrice;

        ShopUpgrades.speedUpgrades++;
        if (ShopUpgrades.speedUpgrades >= 5)
        {
            speedButton.SetActive(false);
            speedPriceText.text = "";
        }
    }
}
