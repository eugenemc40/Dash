using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;//moves player left to right
    private Rigidbody playerRb;
    public float jumpForce = 10;
    public float speed = 10.0f;//player speed
    public float gravityModifier;
    private int level = 10;
    public ProgressBar Pb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        Pb.BarValue = 100;

    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        //updates movement to player based on time and speed
        transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.up * jumpForce);
        }
        
    }
    
}
