using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public bool isplayerdead;
    public int health;
    public int points;
    public int lives;
    public GameObject currentpowerup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            usepowerup();
        }
        if (health <= 0)
        {                       
            if (lives > 0)
            {
                lives--;
                health++;
            }
            else if(lives <= 0)
            {
                isplayerdead = true;
                gameObject.SetActive(false);
            }
        }    
    }

    public void usepowerup()
    {
        //when using a powerup it will spawn in the gameobject prefab that is the current object if there is none it will return
        if (currentpowerup == null)
        {
            Debug.Log("you have no powerup");
            return;

        }
        else
        {
            Instantiate(currentpowerup, transform.position, transform.rotation);
            currentpowerup = null;
        }
    }

}
