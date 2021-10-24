using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3Script : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 0f;
    public int rotate = 0;
    Vector3 moveVector;

    void Start()
    {
        moveVector = new Vector3(1f, 0f, 0f);
    }

    void Update()
    {
        if (distance < 10)
        {
            transform.position = new Vector3(transform.position.x + (moveVector.x * speed * Time.deltaTime), transform.position.y, transform.position.z + (moveVector.z * speed * Time.deltaTime));
            distance += speed * Time.deltaTime;
        }
        else
        {
            if (rotate < 90)
            {
                transform.Rotate(0, -1, 0, Space.Self);
                rotate += 1;
            }
            else
            {
                if (moveVector.x == 0 && moveVector.z == -1)
                {
                    moveVector = new Vector3(1f, 0f, 0f); // prawo
                }
                else if (moveVector.x == 1 && moveVector.z == 0)
                {
                    moveVector = new Vector3(0f, 0f, 1f); // góra
                }
                else if (moveVector.x == 0 && moveVector.z == 1)
                {
                    moveVector = new Vector3(-1f, 0f, 0f); // lewo
                }
                else if (moveVector.x == -1 && moveVector.z == 0)
                {
                    moveVector = new Vector3(0f, 0f, -1f); // dół
                }
                rotate = 0;
                distance = 0;
            }
        }
    }
}