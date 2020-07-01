using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksBombBehavior : MonoBehaviour
{
    public float TimeToDestroyObject;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies )
        {
            EnemyBehavior enemyBehavior;
           enemyBehavior = enemy.GetComponent<EnemyBehavior>();
            enemyBehavior.health = 0;
        }
    }  

    // Update is called once per frame
    void Update()
    {
        Object.Destroy(gameObject, TimeToDestroyObject);
        
    }
}
