using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(15, 0, -0.5f);
    public float startDelay = 2.0f;
    public float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
           InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
