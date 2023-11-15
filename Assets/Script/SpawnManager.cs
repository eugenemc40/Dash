using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private float spawnRangeX = 60;
    private float spawnPosZ = 2.5f;
    private float startDelay = 2;
    private float spawnInterval = 2.5f;
    public ProgressBar Pb;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", startDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        Pb.BarValue = 100;

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
    //method to reduce lifeloss
    void lifeloss(GameObject item)
    {
    
    }

    //method to increase life
    void lifegain(GameObject item)
    {

    }

}
