using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrumbs : MonoBehaviour
{
    public float minSpawnTime, maxSpawnTime;
    public GameObject crumb;

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    private IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));
        }
    }

    private void Spawn()
    {
        Instantiate(crumb, transform.position, Quaternion.identity);
    }
}
