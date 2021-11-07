using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Random = UnityEngine.Random;


public class Lab04Zad01Script : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int quantity = 10;
    int objectCounter = 0;
    public GameObject block;
    private GameObject newBlock;

    void Start()
    {
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        Vector3 platformSize = GameObject.Find("Platform").GetComponent<Terrain>().terrainData.size;

        List<int> pozycje_x = new List<int>(Enumerable.Range(0 + (int)this.transform.position.x, (int)platformSize.x + (int)this.transform.position.x).OrderBy(x => Guid.NewGuid()).Take(quantity));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0 + (int)this.transform.position.z, (int)platformSize.z + (int)this.transform.position.z).OrderBy(x => Guid.NewGuid()).Take(quantity));

        for (int i = 0; i < quantity; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }

        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Material[] mats = Resources.LoadAll("MyMaterials", typeof(Material)).Cast<Material>().ToArray();
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            newBlock = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            newBlock.GetComponent<MeshRenderer>().material = mats[Random.Range(0, 5)];
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}




