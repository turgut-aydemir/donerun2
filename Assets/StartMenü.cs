using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenü : MonoBehaviour
{
    // Play button will start the 1st Level
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    // Quit button exits the app
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
