using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    public int spawnScoreTotal;
    public int maxSpawnScoreTotal;

    public GameObject[] spawnables;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (spawnScoreTotal < maxSpawnScoreTotal)
        {
            foreach (GameObject g in spawnables)
            {
                Instantiate(g, new Vector3(0.0f,0.0f,0.0f), new Quaternion(0.0f,0.0f,0.0f,0.0f));
                spawnScoreTotal++;
            }
        }
        
    }
}
