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
        if (Input.GetKeyDown(KeyCode.E) && !inShop)
        {
            Time.timeScale = 0f;
            SceneManager.LoadScene("ShopScene", LoadSceneMode.Additive);
            inShop = true;
        }

        else if (Input.GetKeyDown(KeyCode.E) && inShop)
        {
            Time.timeScale = 1f;
            SceneManager.UnloadSceneAsync("ShopScene");
            inShop = false;
        }
    }
}
