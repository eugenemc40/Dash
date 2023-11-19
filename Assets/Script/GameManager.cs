using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Pl;
    public GameObject LifeLoss;
    public GameObject LifeGain;
    public ProgressBar Pb;

    // Start is called before the first frame update
    void Start()
    {
        Pb.BarValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
