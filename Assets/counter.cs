using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class counter : MonoBehaviour
{
      public TextMeshProUGUI txt;
    // Start is called before the first frame update
    public int n;
    void Start()
    {
        n=8;
    }

    // Update is called once per frame
    public void decrementCount(){
        n--;
        txt.text= "Number Left : "+n;
        if(n == 0){
            
         SceneManager.LoadScene("closeCHP2");

        }
        
    }
  
    
}
