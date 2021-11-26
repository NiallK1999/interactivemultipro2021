using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneselector : MonoBehaviour
{
   public void MoveScene(string World)
   {
       SceneManager.LoadScene(World);
   }
}
