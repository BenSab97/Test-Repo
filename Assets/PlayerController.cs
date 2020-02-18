using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.5f;
    float h;
    float v;
    Vector3 move = Vector3.zero;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
  
    // Vector3 move = new Vector (0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        move.x = h * speed;
        move.z = v * speed;
        rb.AddForce(move);
    }
}
