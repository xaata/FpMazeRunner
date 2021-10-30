using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController controller;
    private float rotationSpeed = 5;
   
    private float playerSpeed;
    void Start()
    {
        var transform = GetComponent<Transform>();
        playerSpeed = GetComponent<Player>().PlayerSpeed;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rotx = Input.GetAxis("Mouse X");
        float roty = Input.GetAxis("Mouse Y");
        Vector3 moveCal = transform.right * x + transform.forward * z;
        
        controller.Move(moveCal * playerSpeed * Time.deltaTime);
  
        transform.Rotate(Vector3.up * rotx * rotationSpeed);
    }
}
