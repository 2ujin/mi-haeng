using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnMouseOver()
    {
        transform.localScale = new Vector2(0.21f, 0.21f);
    }
    private void OnMouseExit()
    {
        transform.localScale = new Vector2(0.2f, 0.2f);
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void HowToGame()
    {
        SceneManager.LoadScene("HowtoGame");
    }
}
