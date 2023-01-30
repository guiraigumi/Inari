using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadNewGame()
   {
        SceneManager.LoadScene("Movement_dialogue");
   }

    public void LoadExit()
   {
        Application.Quit();
   }
}
