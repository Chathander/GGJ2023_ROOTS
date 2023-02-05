using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D playerRigBod;

    private Input _keyCode;
    [SerializeField]
    private bool isMovingLeft;
    [SerializeField]
    private bool isMovingRight;
    [SerializeField]
    private bool isJumping;
    [SerializeField]
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        playerRigBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    
    // Need to get vector direction of the left and rigth and subract its movement... OK
    // Then! We need to go and attatch the camera to the player.
    // I also need to be able to call specific function in update and others in fixed update... lets give this a try.
    
    //Calls bool to = true! and if true the fixed update calls move the things!.. OK!
    void Update()
    {
        MoveButtonCalls();
    }

    private void FixedUpdate()
    {
        ForceMovement();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }

    private void MoveButtonCalls()
    {
        if (Input.GetKey(KeyCode.A))
        {
            isMovingRight = true;
            Debug.Log("Createdmovement");
        }
        else
        {
            isMovingRight = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            isMovingRight = true;
            Debug.Log("CreatedMovement");
        }
        else
        {
            isMovingLeft = false;
        }

        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            isJumping = true;
            Debug.Log("wow they jumping");
        }
        else
        {
            isJumping = false;
        }
    }

    private void ForceMovement()
    {
        if (isMovingRight)
            playerRigBod.AddForce(transform.right * 10);
        if (isMovingLeft)
            playerRigBod.AddForce(transform.right * -10);
        if (isJumping)
            playerRigBod.AddForce(transform.up * -200);
        
    }
    
}
