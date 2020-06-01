using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject optionsmenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showoptionsmenu()
    {
        optionsmenu.SetActive(true);
        menu.SetActive(false);
    }
}
