using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("SK_GameScene");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
