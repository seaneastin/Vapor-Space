using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneBehavior : MonoBehaviour
{
    public void LoadScene(int buildindex)
    {
        SceneManager.LoadScene(buildindex);
    }

    
}
