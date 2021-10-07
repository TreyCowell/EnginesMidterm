// Game Eng Lab 2 
// Treyton Cowell - 100745472
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private float movespeed;
    private float jumpspeed;
    private float dirX, dirZ;
    // Start is called before the first frame update
    void Start()
    {
        movespeed = 3f;
        jumpspeed = 4f;
        rb = GetComponent<Rigidbody>();
    }

    //Unitys OnTrigger function
    void OnTriggerEnter(Collider col)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Unitys GetKeyDown
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        }

        dirX = Input.GetAxis("Horizontal") * movespeed;
        dirZ = Input.GetAxis("Vertical") * movespeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
