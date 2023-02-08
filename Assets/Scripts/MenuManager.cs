using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

[SerializeField] private GameObject canvas;

    public void LoadNewGame()
   {
        SceneManager.LoadScene("Movement_dialogue");
   }

    public void LoadExit()
   {
        Application.Quit();
   }

    public void ToggleCanvasGroupActive()
   {
       canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);
   }

   public void LoadMenuPrincipal()
   {
       SceneManager.LoadScene("Main Menu");
   }

   public void BattleScene()
   {
        SceneManager.LoadScene("Battle Scene");
   }
}
