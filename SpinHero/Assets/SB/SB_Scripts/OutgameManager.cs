using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OutgameManager : MonoBehaviour
{
    public void GoGameScene()
    {
        SceneManager.LoadScene("SB_Main");
    }
}
