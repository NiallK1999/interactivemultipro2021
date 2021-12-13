using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOOR : MonoBehaviour
{
    // Start is called before the first frame update
   void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player" && GameVariables.keyCount>0)
        {
            //GameVariables.keyCount += 1;
            Destroy(gameObject);
           GameVariables.keyCount -=1;
      
        }
    }
    
}
