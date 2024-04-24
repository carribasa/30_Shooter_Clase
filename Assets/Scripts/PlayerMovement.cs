using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float speed, gravity = -9.81f, jumpForce;
    private Vector3 velocity;

    void LateUpdate()
    {
        if (characterController.isGrounded && velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Horizontal movement
        Vector3 move = (transform.right * x) + (transform.forward * z);
        characterController.Move(speed * Time.deltaTime * move);

        // Gravity
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
        AddJump();
    }

    private void AddJump()
    {
        if (Input.GetButtonDown("Jump") && characterController.isGrounded)
        {
            velocity.y = jumpForce;
        }
    }
}
