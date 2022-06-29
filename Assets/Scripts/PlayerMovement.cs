using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        // Read keyboard input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // Direction of movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // Add force to object using time variable
        rb.AddForce(movement * speed * Time.deltaTime);
        Debug.Log("moveHorizontal = " + moveHorizontal);
    }
}
