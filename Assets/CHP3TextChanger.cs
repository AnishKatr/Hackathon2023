using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class CHP3TextChanger : MonoBehaviour {
   public TextMeshProUGUI txt;
   public Button myButton;
   public string replacement;
   public static int count;
   

   void Start(){
      Button btn = myButton.GetComponent<Button>();
      count = 0;
   }
   public void OnButtonPress(){
      
      txt.text = replacement;
      myButton.interactable= false;
      count++;
      Debug.Log(count);
      
      
   }
   void Update(){
      if (Input.GetMouseButtonDown(0)){
         sceneChanger();
      }
   }

   public void sceneChanger(){
     
      if(count == 4 ){
         
            SceneManager.LoadScene("closeGame");
      }
   }
   
}