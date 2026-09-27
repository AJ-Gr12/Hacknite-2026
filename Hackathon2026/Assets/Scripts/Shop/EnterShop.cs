using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterShop : MonoBehaviour
{
    bool inShop = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !inShop)
        {
            SceneManager.LoadScene("ShopScene", LoadSceneMode.Additive);
            inShop = true;
        }

        if (Input.GetKeyDown(KeyCode.Return) && inShop)
        {
            SceneManager.UnloadSceneAsync("ShopScene");
            inShop = false;
        }
    }
}
