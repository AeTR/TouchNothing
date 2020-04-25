using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControll : MonoBehaviour
{
    // public Rigidbody thisRigidbody;
    public CharacterController thisCharacterController;
    public float forwardBackward;
    public float rightLeft;
    public float mouseX, mouseY;
    public float moveSpeed = 2f;
    public Vector3 inputVector;

    float xRotation = 0f;

    void Awake()
    {
        Cursor.visible = false;
    }
    
    void Start()
    {
        thisCharacterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        //  GET MOUSELOOK
        mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX, 0);

        mouseY = Input.GetAxis("Mouse Y");
        //Camera.main.transform.Rotate(-mouseY, 0, 0);

        xRotation -= mouseY; 
        xRotation = Mathf.Clamp(xRotation, -30f, 75f);
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0, 0); 


        forwardBackward = Input.GetAxis("Vertical");
        rightLeft = Input.GetAxis("Horizontal");

        inputVector = transform.forward * forwardBackward;
        inputVector += transform.right * rightLeft;
        thisCharacterController.Move(inputVector * moveSpeed + (Physics.gravity * .69f));
    }
   
}