using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TextChanger : MonoBehaviour {
   public TextMeshProUGUI txt;
   public Button myButton;
   public string replacement;
   void Start(){
      Button btn = myButton.GetComponent<Button>();

   }
   public void OnButtonPress(){
      
      txt.text = replacement;
      myButton.interactable= false;
   }
}