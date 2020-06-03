using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.0f, -8.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {        
        float x = Input.mousePosition.x;

        transform.position = new Vector3(x, -950.0f, 0.0f);
    }
}
