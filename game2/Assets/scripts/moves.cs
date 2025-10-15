

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    [SerializeField] float moveForce = 100f;
    [SerializeField] float jumpForce = 100f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void FixedUpdate()
    {
        movementLogic();

    }
    private void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    
    private void movementLogic()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movepos = new Vector3(x, 0, z).normalized;
        rb.MovePosition(rb.position + movepos * moveForce * Time.deltaTime);
    }

}
