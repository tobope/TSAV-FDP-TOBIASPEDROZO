using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
      public void play()
      {
          SceneManager.LoadScene(1);
      }
      public void Quit()
      {
          Debug.Log("cerrando");
        Application.Quit();

      }

}