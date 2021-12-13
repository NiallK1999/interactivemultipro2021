using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScripts : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            GameVariables.keyCount += 1;
            Destroy(gameObject);
        }
    }
    
        
    }

