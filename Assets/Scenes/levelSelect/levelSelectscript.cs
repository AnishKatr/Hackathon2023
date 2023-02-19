using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelectscript : MonoBehaviour
{
    // Chapter 1
    public void loadChapter1(){
        
        SceneManager.LoadScene("transitionCHP1");

    }

    //Chapter 2
    public void loadChapter2(){
        
        SceneManager.LoadScene("transitionCHP2");

    }

    //Chapter 3
    public void loadChapter3(){
        
        SceneManager.LoadScene("transitionCHP3");

    }
    
    //Home Button
    public void home(){

        SceneManager.LoadScene("mainMenu");

    }


    //Quit Button
    public void quitGame(){

        Application.Quit();

    }
}
