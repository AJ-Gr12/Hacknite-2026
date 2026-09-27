using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroManager : MonoBehaviour
{
    public GameObject[] pages; // drag Page1, Page2, Page3, Page4 in, in order
    public float fadeDuration = 0.5f;

    private int currentPage = 0;
    private CanvasGroup[] canvasGroups;
    private bool isFading = false;

    void Start()
    {
        canvasGroups = new CanvasGroup[pages.Length];
        for (int i = 0; i < pages.Length; i++)
        {
            canvasGroups[i] = pages[i].GetComponent<CanvasGroup>();
            pages[i].SetActive(true); // all pages stay active now, alpha controls visibility
            canvasGroups[i].alpha = (i == 0) ? 1 : 0;
        }
    }

    public void NextPage()
    {
        if (isFading) return; // prevent spam-clicking mid-fade

        int nextPage = currentPage + 1;

        if (nextPage >= pages.Length)
        {
            GoToGame();
        }
        else
        {
            StartCoroutine(FadeToPage(nextPage));
        }
    }

    IEnumerator FadeToPage(int nextIndex)
    {
        isFading = true;

        CanvasGroup current = canvasGroups[currentPage];
        CanvasGroup next = canvasGroups[nextIndex];

        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float progress = t / fadeDuration;

            current.alpha = 1 - progress;
            next.alpha = progress;

            yield return null;
        }

        current.alpha = 0;
        next.alpha = 1;

        currentPage = nextIndex;
        isFading = false;
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}