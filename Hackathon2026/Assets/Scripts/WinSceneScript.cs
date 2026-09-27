using TMPro;
using UnityEngine;
using System.Collections;

public class WinSceneScript : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    public IEnumerator AnimateText(TMP_Text text)
    {
        yield return new WaitForSeconds(1);


        RectTransform rect = text.GetComponent<RectTransform>();

        // Start small
        rect.localScale = Vector3.zero;

        // Scale up
        float scaleDuration = 0.5f;
        float elapsed = 0f;

        while (elapsed < scaleDuration)
        {
            elapsed += Time.deltaTime / 4;
            float t = elapsed / scaleDuration;

            // Smooth scaling
            t = Mathf.SmoothStep(0f, 1f, t);

            rect.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);

            yield return null;
        }

        rect.localScale = Vector3.one;

        // Spin 360 degrees
        float spinDuration = 0.75f;
        elapsed = 0f;

        while (elapsed < spinDuration)
        {
            elapsed += Time.deltaTime / 4;
            float t = elapsed / spinDuration;

            rect.localRotation = Quaternion.Euler(0f, 0f, t * 360f);

            yield return null;
        }

        rect.localRotation = Quaternion.identity;
    }

    void Start()
    {
        StartCoroutine(AnimateText(text));
    }
}
