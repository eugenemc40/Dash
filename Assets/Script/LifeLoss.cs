using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeLoss : MonoBehaviour
{
    private ProgressBar Pb;
    private PlayerController playerControllerScript;
    private int level = 10;
    private Collider p1;
    private GameObject player;




    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        player = GameObject.Find("Player");
        p1 = player.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        lifeLoss(p1);
    }
    void lifeLoss(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Pb.BarValue < 100)
            {
                Pb.BarValue -= level;
            }
        }
    }
}
