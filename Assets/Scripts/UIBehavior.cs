using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    public PlayerBehavior player;
    public GameBehavior game;
    public Text points;
    public Text lives;
    public Text roundnumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roundnumber.text = "current round: " + game.round;
        points.text = "Points: " + player.points;
        lives.text = "Lives: " + player.lives;
    }
}
