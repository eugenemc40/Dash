using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.HealthSystemCM;

public class Health : MonoBehaviour
{

    private HealthSystem healthSystem;
    //public int damageAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        healthSystem = new HealthSystem(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage() { 
        healthSystem.Damage(10);
    
    }

}
