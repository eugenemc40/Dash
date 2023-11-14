using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatLenth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLenth = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z-repeatLenth)
        {
            transform.position = startPos;
        }
    }
}
