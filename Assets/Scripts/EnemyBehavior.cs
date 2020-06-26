﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class EnemyBehavior : MonoBehaviour
{
    public CharacterController controller;
    public float movementSpeed;
    public float movementRange;
    public GameObject projectile;
    public float shotTime;
    public float shotSpeed;

    public int health;

    public int spawnScore;

    private float shotInterval;

    private bool positiveXDirection = true;

    // Start is called before the first frame update
    void Start()
    {
        shotInterval = shotTime;
    }

    // Update is called once per frame
    void Update()
    {
        //check health to make sure they're alive
        if (health <= 0)
        {
            Destroy(this);
        }

        //enemy movement
        if (transform.position.x >= movementRange || transform.position.x <= -(movementRange))
        {
            positiveXDirection = !positiveXDirection;
            Debug.Log("Switch direction");
        }

        Vector3 movementDirection = new Vector3(0.0f, 0.0f, 0.0f);

        switch (positiveXDirection)
        {
            case true:
                movementDirection += new Vector3(movementSpeed, 0, 0);
                break;
            case false:
                movementDirection += new Vector3(-movementSpeed, 0, 0);
                break;
        }

        controller.Move(movementDirection * Time.deltaTime);

        shotInterval--;
        if (shotInterval == 0)
        {
            shotInterval = shotTime;
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        GameObject shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
        shot.GetComponent<Rigidbody>().AddForce(-(transform.up) * shotSpeed, ForceMode.Force);
        Debug.Log("Shot should move forward");
    }

}
