using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && this.tag == "PlayerBullet")
        {
            Destroy(this.gameObject);
           EnemyBehavior enemy = other.GetComponent<EnemyBehavior>();
            enemy.health = 0;
        }
        else if(other.tag == "MainShip" && this.tag == "EnemyProjectile")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
