using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //List of declared float variables
    private float horizontalInput;
    private float forwardInput;

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float brake = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving the Character
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
