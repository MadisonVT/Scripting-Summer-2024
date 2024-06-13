using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public float gravity = 9.81f;
    
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;
        controller.Move(move * moveSpeed * Time.deltaTime);
        
        // Jumping
        if (controller.isGrounded) // Check if the player is on the ground
        {
            if (Input.GetButtonDown("Jump")) // Check if the jump button is pressed
            {
                // Apply jump force
                moveDirection.y = jumpForce;
            }
        }
        
        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;
        
        // Apply the movement
        controller.Move(moveDirection * Time.deltaTime);
    }     
}