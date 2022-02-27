using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butoon_Play : MonoBehaviour
{
   public void GoToGame()
   {
      SceneManager.LoadScene("Game_Play");
   }

}
