using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontalInput + transform.forward * verticalInput;
        
     
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))  
        {
            moveSpeed = sprintSpeed;
        }
        else
        {
            moveSpeed = 5f;  
        }

        controller.Move(move * moveSpeed * Time.deltaTime);
        
        if (controller.isGrounded) 
        {
            if (Input.GetButtonDown("Jump")) 
            {
                moveDirection.y = jumpForce;
            }
        }
        
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }     
}
