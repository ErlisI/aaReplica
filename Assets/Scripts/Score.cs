using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static int pCount; //pin count
    public Text pText; //public reference to the text

    void Start() {
      pCount = 0;
    }

    //updating the text to the equivalent of count
    void Update() {
      pText.text = pCount.ToString();
    }
}
