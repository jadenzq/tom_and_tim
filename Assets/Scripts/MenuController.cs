using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play(){
        SceneManager.LoadScene("Level 2");
    }

    public void Quit(){
        Application.Quit();
    }
}