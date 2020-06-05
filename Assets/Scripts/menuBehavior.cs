using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void LoadScene(int buildindex)
    {
        SceneManager.LoadScene(buildindex);
    }

    public void quit()
    {
        Application.Quit();
    }
}
