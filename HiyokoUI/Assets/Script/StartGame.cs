using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Fade fade = null;

    public void Fadeout()

    {
        fade.FadeIn(1, () => {

            Invoke("LoadingNewScene", 0.5f);

        });
    }

    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Main");
    }
}
