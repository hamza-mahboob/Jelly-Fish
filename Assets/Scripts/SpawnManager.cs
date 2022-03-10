using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    int startDelay = 2, repeatInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[randomIndex]);
    }
}
