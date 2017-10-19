using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BottomText : MonoBehaviour {
    public Text bottom; 

	// Use this for initialization
	void Start () {
	
	}

   public  void changeText(string str)
    {
        bottom.text = str;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
