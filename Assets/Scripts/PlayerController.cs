using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRb;

    public float speed;
    public float verticalInput;
    public float horizontalInput;
    Vector3 rotationAmount;
    Vector3 moveDirection;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //horisontal input to define the rotation
        rotationAmount = new Vector3(0, horizontalInput, 0);
        moveDirection = new Vector3(0, 0, verticalInput);

        MoveVehicle();
    }

    private void MoveVehicle()
    {
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
        //rotate the Y according to input
        transform.Rotate(rotationAmount);
    }
}