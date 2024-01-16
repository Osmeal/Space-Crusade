using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour
{
    private float timeMax = 4.5f;
    private float timeInit = 0;
    private float hight = 2.8f;
    public GameObject fondo0;
    public GameObject fondo1;
    public GameObject fondo2;
    public GameObject fondo3;
    private GameObject[] fondoArray;
    public GameObject obstacleOrigin;

    void Start()
    {
        fondoArray = new GameObject[] { fondo0, fondo1, fondo2, fondo3 };
        GenerarFondo(fondoArray);
    }

    private void GenerarFondo(GameObject[] fondos)
    {
        int randomIndex = Random.Range(0, fondos.Length);
        GameObject obstacleNew = Instantiate(fondos[randomIndex]);

        obstacleNew.transform.position = obstacleOrigin.transform.position + new Vector3(0, hight, 0);

        Destroy(obstacleNew, 12);
    }

    void Update()
    {

        if (timeInit > timeMax)
        {
            GenerarFondo(fondoArray);
            timeInit = 0;
        }
        else
        {
            timeInit += Time.deltaTime;
        }
    }
}
