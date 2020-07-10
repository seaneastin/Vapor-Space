using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float cooldown;
   
    public GameBehavior game;
    public GameObject projectile;
    public float shotSpeed = 50;
    public float fireRate = 3.0f;    

    // Start is called before the first frame update
    void Start()
    {
        cooldown = fireRate;        
    }

    // Update is called once per frame
    void Update()
    {

        if(game.isinround)
        {
            //Firing cooldown
            cooldown -= Time.deltaTime;

            if (tag == "MainShip")
            {
                //Shoot bullets
                if (Input.GetMouseButton(0) && cooldown <= 0)
                {
                    Vector3 force = new Vector3(0.0f, transform.up.y + 1, 0.0f);
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce(force * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
            else if (tag == "RightShip")
            {
                //Shoot bullets
                if (Input.GetMouseButton(0) && cooldown <= 0)
                {
                    Vector3 force = new Vector3(transform.up.x - 1, 0.0f, 0.0f);
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce(force * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
            else if (tag == "LeftShip")
            {
                //Shoot bullets
                if (Input.GetMouseButton(0) && cooldown <= 0)
                {
                    Vector3 force = new Vector3(transform.up.x + 1, 0.0f, 0.0f);
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce(force * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
        }                
    }
}
