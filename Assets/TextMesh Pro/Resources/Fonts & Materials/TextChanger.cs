using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {
   int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
      GameObject.Find("Button").GetComponentInChildren<Text>().text = "Button clicked " + n + " times.";
   }
}