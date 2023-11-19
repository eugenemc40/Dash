using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeGain : MonoBehaviour
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

        //TriggerStay(playerControllerScript);
    }

    
        void lifeLoss(Collider col)
        {
            if (col.gameObject.tag == "Player")
            {
                if (Pb.BarValue < 100)
                {
                    Pb.BarValue +=level;
                }
            }
        }
          
    
    }
