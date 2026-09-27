using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = ShopUpgrades.hacks + " HackCoins";
    }
}
