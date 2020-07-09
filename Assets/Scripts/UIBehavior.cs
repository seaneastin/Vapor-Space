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
    public Powerup rubiksbomb;
    public Image powerupicon;
    public Sprite defaultitembox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roundnumber.text = "Round: " + game.round;
        points.text = player.points.ToString();
        //lives.text = "Lives: " + player.lives;
        if (player.currentpowerup != null)
        {
            string powerupname = player.currentpowerup.name;

            if (powerupname == rubiksbomb.name)
            {
                powerupicon.sprite = rubiksbomb.hudicon;
            }
        }
        else
        {
            powerupicon.sprite = defaultitembox;
        }

        

    }
}
