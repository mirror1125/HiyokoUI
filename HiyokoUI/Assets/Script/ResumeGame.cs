using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{
    //　ポーズで表示するUI
    [SerializeField]
    private GameObject pauseUI;

    public void Resume()
    {
        //　ポーズUIのアクティブ、非アクティブを切り替え
        pauseUI.SetActive(!pauseUI.activeSelf);

        //　ポーズUIが表示されてる時は停止
        if (pauseUI.activeSelf)
        {
            Time.timeScale = 0f;
            //　ポーズUIが表示されてなければ通常通り進行
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

}
