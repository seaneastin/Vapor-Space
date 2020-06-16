using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopmenuBehavior : MonoBehaviour

{
    //switch this to the actutal player when this is merged with master
    public PlayerBehavior Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buy (Powerup powerup)
    {
        if (Player.points > powerup.cost)
        {
            Player.points -= powerup.cost;
            Player.currentpowerup = powerup.item;
        }
    }
}
