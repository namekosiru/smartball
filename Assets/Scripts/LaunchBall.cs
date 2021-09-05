using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public GameObject ball;
    public float zforce;
    Vector3 force;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(16.6f, 1.21f, -23.6f);
        rb = ball.GetComponent<Rigidbody>();
        force = new Vector3(0.0f, 0.0f, zforce);
    }

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Debug.Log("ok");
            rb.AddForce(force);
        }
    }
}
