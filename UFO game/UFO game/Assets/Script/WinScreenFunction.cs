using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Not necessary, just turn off the game object on start
[System.Obsolete]
public class WinScreenFunction : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(false);
    }

    

}
