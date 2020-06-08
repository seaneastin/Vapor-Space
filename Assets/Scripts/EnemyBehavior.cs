using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    public CharacterController controller;
    public float movementSpeed;
    public float movementRange;

    private bool positiveXDirection = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
