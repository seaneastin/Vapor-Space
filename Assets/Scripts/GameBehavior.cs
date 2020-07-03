using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public GameObject[] enemies;
    public SpawnerBehavior spawner;
    public GameObject finishedroundmenu;
    public GameObject shoptext;
    public GameObject gotoshopbutton;
    public GameObject UI;
    public bool isinround;
    private int roundstillshopshows;
    public int shopintervals;
    public int round;
    // Start is called before the first frame update
    void Start()
    { 
        roundstillshopshows = shopintervals;
        round = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isinround == true)
        {
            //replace this line with something more effiencent
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if (spawner.spawnScoreTotal >= spawner.maxSpawnScoreTotal && enemies.Length <= 0)
            {
                isinround = false;
                roundstillshopshows -= 1;
                round++;
                GameObject[] enemybullets;
                GameObject[] playerBullets;
                playerBullets = GameObject.FindGameObjectsWithTag("PlayerBullet");
                enemybullets = GameObject.FindGameObjectsWithTag("EnemyProjectile");
                UI.SetActive(false);
                foreach (GameObject projectile in enemybullets)
                {
                    GameObject.Destroy(projectile);
                }
                foreach(GameObject bullet in playerBullets)
                {
                    GameObject.Destroy(bullet);
                }
                if (roundstillshopshows <= 0)
                {
                    finishedroundmenu.SetActive(true);
                    shoptext.SetActive(true);
                    gotoshopbutton.SetActive(true);
                    roundstillshopshows = shopintervals;
                }
                else
                {
                    finishedroundmenu.SetActive(true);
                    shoptext.SetActive(false);
                    gotoshopbutton.SetActive(false);

                }

            }
        }
       
    }

    public void startround()
    {
        UI.SetActive(true);
        isinround = true;
        spawner.spawnScoreTotal = 0;
    }
}
