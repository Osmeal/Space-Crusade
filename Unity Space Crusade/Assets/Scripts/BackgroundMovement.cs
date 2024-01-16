using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    void Update()
    {
        if (Time.timeScale == 1)
        GetComponent<Transform>().Translate(0,-0.002f,0);
    
    }
}
