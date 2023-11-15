using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject prefabToSpawn; // El objeto que queremos instanciar
    public float minSpawnInterval = 1.0f; // Intervalo mínimo de tiempo entre spawns
    public float maxSpawnInterval = 5.0f; // Intervalo máximo de tiempo entre spawns

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }

}
