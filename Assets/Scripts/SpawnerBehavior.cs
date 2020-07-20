using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    private int spawnDelay;
    public int spawnTimer;

    public int spawnedEnemyTotal;
    public int maxSpawnedEnemiesTotal;

    public GameObject[] spawnables = new GameObject[3];

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
            int g = Random.Range(1, 11);
            int selectedObjectInArray;
            if (g >= 1 && g <= 6)
            {
                Instantiate(spawnables[0], transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            }
            else if (g >=7 && g <= 9)
            {
                Instantiate(spawnables[1], transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            }
            else if (g == 10)
            {
                Instantiate(spawnables[2], transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            }
            spawnedEnemyTotal++;
            RandomizePosition();
        }
        spawnDelay--;
    }

    void RandomizePosition()
    {
        transform.position = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), 0.0f);
    }
}
