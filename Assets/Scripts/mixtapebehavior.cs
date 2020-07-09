using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mixtapebehavior : MonoBehaviour
{
    List<GameObject> playerships;
    // Start is called before the first frame update
    void Start()
    {
        playerships.Add(GameObject.FindGameObjectWithTag("main"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
