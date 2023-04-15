using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    float gravity = 10f;

    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        if (controller.isGrounded)
        {
            direction = new Vector3(moveHorizontal, 0, moveVertical);
            direction = transform.TransformDirection(direction) * speed;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = jumpForce;
            }
        }
        
        direction.y -= gravity * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 15;
        }
        else
        {
            speed = 10;
        }

        
        controller.Move(direction * Time.deltaTime);
    }
}
