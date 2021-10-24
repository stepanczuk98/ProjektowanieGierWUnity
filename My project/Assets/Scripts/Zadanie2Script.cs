using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2Script : MonoBehaviour
{
    public float speed = 1f;
    public int moveDirection;

    void Start()
    {
    }

    void Update()
    {
        if (transform.position.x >= 10)
        {
            moveDirection = -1;
        }
        else if (transform.position.x <= 0)
        {
            moveDirection = 1;
        }
        transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime * moveDirection), 0, 0);
    }
}