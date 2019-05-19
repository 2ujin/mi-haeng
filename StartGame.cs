using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseOver()
    {
        transform.localScale = new Vector2(0.21f, 0.21f);
    }
    private void OnMouseExit()  
    {
        transform.localScale = new Vector2(0.2f, 0.2f);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("MainGame"); 
    }
}
