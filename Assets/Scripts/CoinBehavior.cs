using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    public int HowMuchThePlayerWastedOnTheShop;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(HowMuchThePlayerWastedOnTheShop, HowMuchThePlayerWastedOnTheShop, transform.localScale.z);
    }
}
