using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class TextChanger : MonoBehaviour {
   int n;
   public TextMeshProUGUI txt;
   public string replacement;
   public void OnButtonPress(){
      
      txt.text = replacement;
   }
}