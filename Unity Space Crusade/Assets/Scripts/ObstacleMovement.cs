using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public float velocidadMovimiento = 0.003f;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            MoveObstacle();
        }
    }

    void MoveObstacle()
    {
        float movimientoVertical = -velocidadMovimiento * Time.deltaTime;
        transform.Translate(0, movimientoVertical, 0);
    }
}
