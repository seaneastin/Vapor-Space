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

        //if (tag == "MainShip")
        //    transform.position = new Vector3(0.0f, -8.0f, 0.0f);
        //else if (tag == "RightShip")
        //    transform.position = new Vector3(17.0f, 0.0f, 0.0f);
        //else if (tag == "LeftShip")
        //    transform.position = new Vector3(-17.0f, 0.0f, 0.0f);
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
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce((transform.up) * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
            else if (tag == "RightShip")
            {
                //Shoot bullets
                if (Input.GetMouseButton(0) && cooldown <= 0)
                {
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce(-(transform.right) * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
            else if (tag == "LeftShip")
            {
                //Shoot bullets
                if (Input.GetMouseButton(0) && cooldown <= 0)
                {
                    GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                    shot.GetComponent<Rigidbody>().AddForce((transform.right) * shotSpeed, ForceMode.Force);
                    cooldown = fireRate;
                }
            }
        }                
    }
}
