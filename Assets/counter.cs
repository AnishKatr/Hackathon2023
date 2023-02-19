using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    // Start is called before the first frame update
    public int n;
    void Start()
    {
        n=8;
    }

    // Update is called once per frame
    public void decrementCount(){
        n--;
        Debug.Log(n);
    }
  
}
