using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScore : MonoBehaviour
{
    GameObject ControlCenter;
    void Start()
    {
        ControlCenter = GameObject.Find("ControlCenter");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ControlCenter.GetComponent<ScoreController>().updateScore();
    }
}
