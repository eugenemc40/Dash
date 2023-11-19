using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private float spawnRangeX = 60;
    private float spawnPosZ = 2.5f;
    private float startDelay = 2;
    private float spawnInterval = 2.5f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        

    }
    // Update is called once per frame
    void Update()
    {
       
    }

     void SpawnItems ()
    {
        //randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0,Random.Range (-spawnPosZ,5));

        int itemIndex = Random.Range(0, itemPrefabs.Length);
        Instantiate(itemPrefabs[itemIndex], spawnPos,
            itemPrefabs[itemIndex].transform.rotation);
       
    }
  
}
