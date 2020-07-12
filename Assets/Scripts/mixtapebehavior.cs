using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class MixtapeBehavior : MonoBehaviour
{
    public float powerupTime;
    public float changedshotspeed;
    public float changedfirerate;
    float originalshotspeed;
    float originalfirerate;
    bool isobjectbeingdestroyed;
    List<GameObject> playerships = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        playerships.Add(GameObject.FindGameObjectWithTag("MainShip"));
        playerships.Add(GameObject.FindGameObjectWithTag("LeftShip"));
        playerships.Add(GameObject.FindGameObjectWithTag("RightShip"));
        PlayerController player = playerships[0].GetComponent<PlayerController>();
        originalfirerate = player.fireRate;
        originalshotspeed = player.shotSpeed;
        foreach (GameObject playership in playerships)
        {
            PlayerController playerController = playership.GetComponent<PlayerController>();
            playerController.fireRate = changedfirerate;
            playerController.shotSpeed = changedshotspeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (powerupTime <= 0)
        {
            foreach (GameObject playership in playerships)
            {
                PlayerController playerController = playership.GetComponent<PlayerController>();
                playerController.fireRate = originalfirerate;
                playerController.shotSpeed = originalshotspeed;
            }
            GameObject.Destroy(this);
        }
        
        
        powerupTime -= Time.deltaTime;

    }
}
