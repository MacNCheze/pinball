using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resart : MonoBehaviour
{
    public string nameOfTheSceneToLoad;
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
        { 
            SceneManager.LoadScene(nameOfTheSceneToLoad); 
        }
    }
}
