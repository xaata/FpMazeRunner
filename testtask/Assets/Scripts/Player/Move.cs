using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        var transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float rot = Input.GetAxis("Mouse X");

        Vector3 moveCal = transform.right * x + transform.forward * z;
        
        controller.Move(moveCal * 5 * Time.deltaTime);

        transform.Rotate(Vector3.up * rot * 5);
    }
}
