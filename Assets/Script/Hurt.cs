
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public ProgressBar Pb;
    public int val=10;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Pb.BarValue > 0)
            {
                Pb.BarValue -= val;

            }
            


            
        }
    }
}
