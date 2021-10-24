using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie5Script : MonoBehaviour
{
    public GameObject myPrefab;
    int x;
    int z;
    bool add = true;
    int[,] objects = new int[10, 2];
    void Start()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            add = true;
            x = Random.Range(1, 10);
            z = Random.Range(1, 10);

            for (int j = 0; j < 10; j++)
            {
                if (objects[j, 0] == x && objects[j, 1] == z)
                {
                    i += -1;
                    add = false;
                }
            }
            if (add == true)
            {
                objects[i, 0] = x;
                objects[i, 1] = z;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(myPrefab, new Vector3(objects[i, 0], 0.5f, objects[i, 1]), Quaternion.identity);
        }
    }
}
