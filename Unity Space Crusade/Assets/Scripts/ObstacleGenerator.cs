using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
        private float timeMax = 4;
        private float timeInit = 0;
        private float width = 1f;

        public GameObject obstacle0;
        public GameObject obstacle1;
        public GameObject obstacle2;
        public GameObject obstacle3;
        public GameObject obstacleOrigin;
        private GameObject[] obstacleArray;




        void Start()
        {
                obstacleArray = new GameObject[] { obstacle0, obstacle1, obstacle2, obstacle3 };
        }

        private void GenerarObstaculo(GameObject[] obstacles)
        {
                int randomIndex = Random.Range(0, obstacles.Length);
                GameObject obstacleNew = Instantiate(obstacles[randomIndex]);

                obstacleNew.transform.position = obstacleOrigin.transform.position + new Vector3(Random.Range(width, -width),  0, 0);

                Destroy(obstacleNew, 8);
        }


        private void Update()
        {
                if (timeInit > timeMax)
                {
                        GenerarObstaculo(obstacleArray);
                        timeInit = 0;
                }
                else
                {
                        timeInit += Time.deltaTime;
                }
        }
}