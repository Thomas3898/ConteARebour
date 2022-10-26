using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Manager : MonoBehaviour
{
    public GameManager manager;
    public GameObject[] spawnPoints;
    public GameObject[] prefabHidding;
    public int indexSpawnPoints0;
    public int indexSpawnPoints1;
    public int indexSpawnPoints2;
    public int indexSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAndSweepHidding());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnAndSweepHidding()
    {

        indexSpawnPoints0 = Random.Range(0, 6);
        indexSpawnPoints1 = Random.Range(0, 6);
        indexSpawnPoints2 = Random.Range(0, 6);

        for(int i = 0; i < 3; i++)
        {
            Instantiate(prefabHidding[Random.Range(0, 2)], spawnPoints[Random.Range(0, 6)].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0, 2));
        }

        yield return new WaitForSeconds(Random.Range(1,3));

        StartCoroutine(SpawnAndSweepHidding());
    }
}
