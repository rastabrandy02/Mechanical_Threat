using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneScript : MonoBehaviour
{
   public void LoadGame()
    {
        SceneManager.LoadScene("Nivel 1");

    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
