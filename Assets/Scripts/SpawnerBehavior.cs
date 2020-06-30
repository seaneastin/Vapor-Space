﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    public int spawnScoreTotal;
    public int maxSpawnScoreTotal;

    private int spawnDelay;
    public int spawnTimer;

    public GameObject[] spawnables;

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        while (spawnScoreTotal < maxSpawnScoreTotal)
        {
            if (spawnDelay == 0)
            {
                for (int g = 0; g > spawnables.Length; g++)
                {
                    spawnDelay = spawnTimer;
                    Instantiate(spawnables[g], new Vector3(0.0f, 0.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
                    spawnables[g].SetActive(true);
                    spawnScoreTotal++;
                }
            }
            spawnDelay--;
        }
        
    }
}
