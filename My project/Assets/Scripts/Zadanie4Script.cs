using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie4Script : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + velocity);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
    }

}
