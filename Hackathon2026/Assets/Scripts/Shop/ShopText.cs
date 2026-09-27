using TMPro;
using UnityEngine;

public class ShopText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] TextMeshProUGUI ammoText;
    [SerializeField] TextMeshProUGUI timeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedText.text = "Speed " + UpgradeCount(3, 8);
        ammoText.text = "Ammo  " + UpgradeCount(2, 8);
        timeText.text = "Time  " + UpgradeCount(4, 8);
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
}
