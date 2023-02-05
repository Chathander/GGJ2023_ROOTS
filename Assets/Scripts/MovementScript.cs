using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D playerRigBod;

    private Input _keyCode;
    // Start is called before the first frame update
    void Start()
    {
        playerRigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    
    // Need to get vector direction of the left and rigth and subract its movement... OK
    // Then! We need to go and attatch the camera to the player.
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        LocalLeftRight();
    }

    private void LocalLeftRight()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerRigBod.AddForce(transform.right * 10);
            Debug.Log("Createdmovement");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerRigBod.AddForce(transform.right * -10);
            Debug.Log("CreatedMovement");
        }
    }
    
}
