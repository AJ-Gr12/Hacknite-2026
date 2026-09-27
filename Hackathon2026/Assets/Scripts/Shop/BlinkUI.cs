using TMPro;
using UnityEngine;

public class BlinkUI : MonoBehaviour
{
    bool blink;
    float timer;
    TextMeshProUGUI text;
    void Start()
    {
        timer = 0.5f;
        blink = true;

        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = 0.5f;
            if (blink)
            {
                blink = false;
                text.text = "^";
            } 
            else
            {
                blink = true;
                text.text = "";
            }
            
        }
    }
}
