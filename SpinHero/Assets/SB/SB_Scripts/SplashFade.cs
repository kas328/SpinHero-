using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashFade : MonoBehaviour
{
    public Image splashImage;
    public string loadLevel;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(3.6f);
        FadeOut();
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 1.0f, false);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
