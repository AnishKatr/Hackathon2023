using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuscript : MonoBehaviour
{
    //initialize game
    public void playGame(){
        
        SceneManager.LoadScene("Chapter1_OCD");

    }

    //level select
    public void loadSelect(){
        
        SceneManager.LoadScene("levelSelect");

    }

    //home button
    public void home(){

        SceneManager.LoadScene("mainMenu");

    }

    //Quit Button
    public void quitGame(){

        Application.Quit();

    }
}
