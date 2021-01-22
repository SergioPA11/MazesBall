using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
            rb.velocity = new Vector3(0,5,0);
    }
}
