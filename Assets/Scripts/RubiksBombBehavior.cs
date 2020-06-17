using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksBombBehavior : MonoBehaviour
{
    public float TimeToDestroyObject;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies )
        {
            Debug.LogWarning("destroy enemies is not implemented");
        }
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
}
