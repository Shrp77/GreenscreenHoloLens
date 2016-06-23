using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

    public GameObject LensButton;
    public GameObject LensMenu;

	// Use this for initialization
	public void FadeLensButton()
    {
        StartCoroutine(DoFadeLensButton());
    }

    public void FadeLensMenu()
    {
        StartCoroutine(DoFadeLensMenu());
    }

    IEnumerator DoFadeLensButton()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while(canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        LensButton.SetActive(false);
        LensMenu.SetActive(true);
        canvasGroup.alpha = 1;
        yield return null;
    }

    IEnumerator DoFadeLensMenu()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        LensButton.SetActive(true);
        LensMenu.SetActive(false);
        canvasGroup.alpha = 1;
        yield return null;
    }
}
