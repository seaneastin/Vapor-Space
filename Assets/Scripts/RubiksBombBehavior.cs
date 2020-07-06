using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksBombBehavior : MonoBehaviour
{
    public GameObject rubiksbombsolve;
    public GameObject rubiksbombexplode;
    Animator rubiksbombsolveanim;
    Animator rubiksbombexplodeanim;
    GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        rubiksbombsolveanim = rubiksbombsolve.GetComponent<Animator>();
        rubiksbombexplodeanim = rubiksbombexplode.GetComponent<Animator>();
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }  

    // Update is called once per frame
    void Update()
    {
        if (rubiksbombsolveanim.GetCurrentAnimatorStateInfo(0).IsName("Solve"))

            if (rubiksbombsolveanim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            rubiksbombsolve.SetActive(false);
            rubiksbombexplode.SetActive(true);
        }

        if (rubiksbombexplodeanim.GetCurrentAnimatorStateInfo(0).IsName("Explode"))
        {
            if (rubiksbombexplodeanim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                foreach (GameObject enemy in enemies)
                {
                    EnemyBehavior enemyBehavior;
                    enemyBehavior = enemy.GetComponent<EnemyBehavior>();
                    enemyBehavior.health = 0;
                    
                }
                Object.Destroy(gameObject);
            }
        }
    }
}
