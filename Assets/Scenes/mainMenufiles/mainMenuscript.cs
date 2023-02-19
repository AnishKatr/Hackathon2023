using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuscript : MonoBehaviour
{
    // Chapter 1
    public void loadChapter1(){
        
        SceneManager.LoadScene("Chapter1_OCD");

    }

    //Chapter 2
    public void loadChapter1(){
        
        SceneManager.LoadScene("Chapter2");

    }

    public void home(){

        SceneManager.LoadScene("mainMenu");

    }

    public void quitGame(){

        Application.Quit();

    }
}
