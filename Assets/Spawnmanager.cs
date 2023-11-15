using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject prefabToSpawn; // El objeto que queremos instanciar
    public float spawnInterval = 2.0f; // Intervalo de tiempo entre spawns

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0, spawnInterval);
    }

    void SpawnObject()
    {
        Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
    }


}
