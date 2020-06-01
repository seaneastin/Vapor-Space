using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneBehavior : MonoBehaviour
{
    void LoadScene(int buildindex)
    {
        SceneManager.LoadScene(buildindex);
    }

    
}
