using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rankController : MonoBehaviour {

    public Text rank1;
    public Text rank2;
    public Text rank3;
    public Text rank4;
    public Text rank5;
    public Text rank6;
    public Text rank7;
    public Text rank8;
    public Text rank9;
    public Text rank10;

    void Start () {
         rank1.text = PlayerPrefs.GetFloat("score").ToString();
        rank2.text = PlayerPrefs.GetFloat("score").ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
