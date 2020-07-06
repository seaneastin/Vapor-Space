using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shopmenuBehavior : MonoBehaviour

{
    //switch this to the actutal player when this is merged with master
    public PlayerBehavior Player;
    public GameObject[] hellotextboxes;
    public GameObject[] purchasetextboxes;
    public GameObject[] goodbyetextboxes;
    public Text cost;
    public Text Points;
    public GameObject shopmenu;
    public GameBehavior game;
    public GameObject buyconfirmation;
    public Text buyconfirmationtextbox;
    public Button buybutton;

    // Start is called before the first frame update
    void Start()
    {
        hellotextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Points.text = "Points: " + Player.points;

    }

    public void showcost(Powerup powerup)
    {
        cost.text = "Cost: " + powerup.cost;
    }

    public void showconfirmationmenu(Powerup powerup)
    {
        buyconfirmation.SetActive(true);
        buyconfirmationtextbox.text = "are you sure you want to buy " + powerup.name + " for " + powerup.cost + " points";
        buybutton.onClick.AddListener(() => buy(powerup));
}

    public void buy(Powerup powerup)
    {
        cleartexbox();
        if (Player.points > powerup.cost)
        {
            powerup.description.SetActive(false);
            Player.points -= powerup.cost;
            Player.currentpowerup = powerup.item;

            purchasetextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
            buyconfirmation.SetActive(false);
        }
        else
        {
            buyconfirmationtextbox.text = "you dont have enough points to buy this";
        }
    }


    public void leaveshop()
    {
        cleartexbox();
        goodbyetextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
        shopmenu.SetActive(false);
        game.startround();
    }

    public void cleartexbox()
    {
        foreach (GameObject hellotextbox in hellotextboxes)
        {
            hellotextbox.SetActive(false);
        }

        foreach (GameObject purchasetextbox in purchasetextboxes)
        {
            purchasetextbox.SetActive(false);
        }

        foreach (GameObject goodbyetextbox in goodbyetextboxes)
        {
            goodbyetextbox.SetActive(false);
        }

    }



}
