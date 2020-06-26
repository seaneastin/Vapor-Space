using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public GameObject[] enemies;
    public SpawnerBehavior spawner;
    private int roundstillshopshows;
    public int shopintervals;
    public GameObject shopmenu;
    public int round;
    // Start is called before the first frame update
    void Start()
    { 
        roundstillshopshows = shopintervals;
    }

    // Update is called once per frame
    void Update()
    {
        //replace this line with something more effiencent
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (spawner.spawnScoreTotal >= spawner.maxSpawnScoreTotal && enemies.Length <= 0)
        {
            roundstillshopshows -= 1;
            round++;
            if (roundstillshopshows <= 0)
            {
                shopmenu.SetActive(true);
            }
            else
            {
                startround();
            }

        }
    }

    public void startround()
    {
        spawner.spawnScoreTotal = 0;
    }
}
