using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("GameWorld");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
