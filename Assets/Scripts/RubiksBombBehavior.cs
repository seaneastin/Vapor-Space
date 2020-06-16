using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksBombBehavior : MonoBehaviour
{
    public float TimeToDestroyObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }  

    // Update is called once per frame
    void Update()
    {
        if (TimeToDestroyObject <= 0)
        {
            Object.Destroy(gameObject);
        }

        TimeToDestroyObject -= 1;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("is an enemy");
            other.SendMessage("kill");
        }
    }
}
