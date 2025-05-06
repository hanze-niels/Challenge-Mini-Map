using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    private float turningSpeed = 50f;
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(0, 0, verticalInput * movementSpeed * Time.deltaTime);
        transform.Rotate(0, horizontalInput * turningSpeed * Time.deltaTime, 0);
    }
}
