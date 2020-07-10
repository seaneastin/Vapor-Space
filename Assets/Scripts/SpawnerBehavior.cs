using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    private int spawnDelay;
    public int spawnTimer;

    public int spawnedEnemyTotal;
    public int maxSpawnedEnemiesTotal;

    public GameObject[] spawnables;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = spawnTimer;
        RandomizePosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnDelay == 0 && spawnedEnemyTotal < maxSpawnedEnemiesTotal)
        {
            spawnDelay = spawnTimer;
            int g = Random.Range(0, (spawnables.Length - 1));
            Instantiate(spawnables[g], transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            spawnedEnemyTotal++;
            RandomizePosition();
        }
        if(spawnDelay != 0)
        {
            spawnDelay--;
        }        
    }

    void RandomizePosition()
    {
        Vector3 oldSpawn = transform.position;
        transform.position = new Vector3(Random.Range(-3.9f, 3.9f), Random.Range(2.0f, 6.0f), 0.0f);

        if ((oldSpawn - transform.position).magnitude <= 3)
        {
            RandomizePosition();
        }
    }
}
