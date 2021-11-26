using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneselector : MonoBehaviour
{
   public void ButtonMoveScene(string Level1)
   {
       SceneManager.LoadScene(Level1);
   }
}
