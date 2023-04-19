using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMainmenu : MonoBehaviour
{
    public void GotoMain()
    {
        SceneManager.LoadScene("SK_MainMenu");
    }
}
