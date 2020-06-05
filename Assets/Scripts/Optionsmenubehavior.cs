using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;



public class Optionsmenubehavior : MonoBehaviour
{
 
    public GameObject menu;
    
    public GameObject optionsmenu;

    public Dropdown resolutionsdropdown;
    Resolution[] resolutions;
    // Start is called before the first frame update
    public Toggle fullscreentoggle;

    void Start()
    {
        //checks to see if game is in fullscreen or not
        fullscreentoggle.isOn = Screen.fullScreen;

        //gets the available resoultions for the device
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();
        //stores the resoultion options
        List<string> options = new List<string>();
        resolutionsdropdown.ClearOptions();
        //stores the index for the current reslution so that the options menu will show the current resolution when the menu is opened
        int currentresoultionindex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            //checks to see if the resolution being added is the current reslution
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentresoultionindex = i;
            }
        }

        resolutionsdropdown.AddOptions(options);
        resolutionsdropdown.value = currentresoultionindex;
        resolutionsdropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void setResolution (int resoultionIndex)
    {
        Resolution resoution = resolutions[resoultionIndex];
        Screen.SetResolution(resoution.width, resoution.height, Screen.fullScreen);
    }    
    

    public void showmainmenu()
    {

        menu.SetActive(true);
        optionsmenu.SetActive(false);
    }

    public void setfullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }

}
