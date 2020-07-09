using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;
public class shopmenuBehavior : MonoBehaviour

{
    //switch this to the actutal player when this is merged with master
    public CoinBehavior coin; 
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
    public GameObject Head;
    Animator head_animation;
    bool isleavingshop = false;
    // Start is called before the first frame update
    void Start()
    {
        head_animation = Head.GetComponent<Animator>();
        hellotextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Points.text = "Points: " + Player.points;
        //activates once leave shop animation is playing
        if  (head_animation.GetCurrentAnimatorStateInfo(0).IsName("Goodbye"))
        {
            if (isleavingshop == true)
            {
                isleavingshop = false;
                cleartexbox();
                goodbyetextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
            }
            if (head_animation.IsInTransition(0))
            {
                cleartexbox();
                game.startround();
                shopmenu.SetActive(false);
                Head.SetActive(false);

            }
        }
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
            head_animation.SetTrigger("Purchase");
            purchasetextboxes[Random.Range(0, hellotextboxes.Length)].SetActive(true);
            buyconfirmation.SetActive(false);
            coin.HowMuchThePlayerWastedOnTheShop += powerup.cost;
        }
        else
        {
            buyconfirmationtextbox.text = "you dont have enough points to buy this";
        }
    }


    public void leaveshop()
    {
        isleavingshop = true;
        head_animation.SetTrigger("Goodbye");
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

    public void shopkeeperdesciptionanim()
    {
        head_animation.SetTrigger("Explanation");
    }

    public void shopkeeperwelcomeanim()
    {
        //head_animation.SetTrigger("Welcome");
    }

}
