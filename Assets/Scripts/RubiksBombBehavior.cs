using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksBombBehavior : MonoBehaviour
{
    public GameObject rubiksbombsolve;
    public GameObject rubiksbombexplode;
    public float speed;
    Animator rubiksbombsolveanim;
    Animator rubiksbombexplodeanim;
    public GameObject explosionparticle;
    GameObject[] enemies;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
        rubiksbombsolveanim = rubiksbombsolve.GetComponent<Animator>();
        rubiksbombexplodeanim = rubiksbombexplode.GetComponent<Animator>();
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }  

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 1, 0);
        movement *= speed;
        if (rubiksbombsolveanim.GetCurrentAnimatorStateInfo(0).IsName("Solve"))
            characterController.Move(movement * Time.deltaTime);
            if (rubiksbombsolveanim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            rubiksbombsolve.SetActive(false);
            rubiksbombexplode.SetActive(true);
            explosionparticle.SetActive(true);
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
