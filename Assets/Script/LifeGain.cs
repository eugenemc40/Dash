using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeGain : MonoBehaviour
{
    private ProgressBar Pb;
    private PlayerController playerControllerScript;
    private int level=10;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerStay(Collider col)
    {
if (col.gameObject.tag == "Player")
        {
            if (Pb.BarValue < 100)
            {
                Pb.BarValue += level;
            }
            else
            {
                //Debug("")
            }
        }
    }
    
    }
