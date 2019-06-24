using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gohome_btn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector2(0, -478);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GameStart()
    {
        SceneManager.LoadScene("StartGame");
    }
}
