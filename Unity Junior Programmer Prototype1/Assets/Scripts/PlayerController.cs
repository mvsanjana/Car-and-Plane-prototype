using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;   //So as to change the speed of the vehicle from the inspector
    //public access modifier makes speed variable accessible from anywhere, even inspector window
    // Start is called before the first frame update
    private float turnSpeed = 25.0f;
    private float horizontalInput; // Player can control steering now (left and right)
    private float forwardInput;  //Player can now control the gas (acceleration: forward and backward)
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input/control (arrows or wasd)
        horizontalInput = Input.GetAxis("Horizontal");     
        forwardInput = Input.GetAxis("Vertical"); 

        //We'll move the vehicle forward
        //transform.Translate(0,0, 1);
        //transform.Translate(Vector3.forward);
        //transform.Translate(Vector3.forward * Time.deltaTime * 20);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //We'll move the vehicle sideway
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);  //This does not rotate the vehicle, so use Rotate()
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
