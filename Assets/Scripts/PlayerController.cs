using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    

    public float fireRate = 3.0f;
    private float cooldown;
    

    public GameObject projectile;
    public float shotSpeed = 50;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cooldown = fireRate;

        if (tag == "MainShip")
            transform.position = new Vector3(0.0f, -8.0f, 0.0f);
        else if (tag == "RightShip")
            transform.position = new Vector3(17.0f, 0.0f, 0.0f);
        else if (tag == "LeftShip")
            transform.position = new Vector3(-17.0f, 0.0f, 0.0f);
        else if (tag == "TopShip")
            transform.position = new Vector3(0.0f, 10.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {


        //Firing cooldown
        cooldown -= Time.deltaTime;

        if (tag == "MainShip")
        {
            //Variable to hold mouse position
            Vector3 mousePos = Input.mousePosition;

            //Use the current camera to convert mouse position to a ray
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);

            //Create a plane that faces up at the same position as the player
            Plane playerPosPlane = new Plane(Vector3.up, transform.position);

            //How far along the ray does the intersection with the plan occur?
            float rayDistance = 0;
            playerPosPlane.Raycast(mouseRay, out rayDistance);

            //Use the ray distance to calculate the point of collision
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            //Move agent to target point
            transform.position = new Vector3(targetPoint.x, -8.0f, 0.0f);

            //Shoot bullets
            if (Input.GetMouseButton(0) && cooldown <= 0)
            {
                GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                shot.GetComponent<Rigidbody>().AddForce((transform.up) * shotSpeed, ForceMode.Force);
                cooldown = fireRate;
            }
        }
        else if(tag == "RightShip")
        {
            //Variable to hold mouse position
            Vector3 mousePos = Input.mousePosition;

            //Use the current camera to convert mouse position to a ray
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);

            //Create a plane that faces up at the same position as the player
            Plane playerPosPlane = new Plane(Vector3.up, transform.position);

            //How far along the ray does the intersection with the plan occur?
            float rayDistance = 0;
            playerPosPlane.Raycast(mouseRay, out rayDistance);

            //Use the ray distance to calculate the point of collision
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            //Move agent to target point
            transform.position = new Vector3(17.0f, targetPoint.y , 0.0f);

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
            //Variable to hold mouse position
            Vector3 mousePos = Input.mousePosition;

            //Use the current camera to convert mouse position to a ray
            Ray mouseRay = Camera.main.ScreenPointToRay(mousePos);

            //Create a plane that faces up at the same position as the player
            Plane playerPosPlane = new Plane(Vector3.up, transform.position);

            //How far along the ray does the intersection with the plan occur?
            float rayDistance = 0;
            playerPosPlane.Raycast(mouseRay, out rayDistance);

            //Use the ray distance to calculate the point of collision
            Vector3 targetPoint = mouseRay.GetPoint(rayDistance);

            //Move agent to target point
            transform.position = new Vector3(-17.0f, targetPoint.y, 0.0f);

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
