using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector2(275f, 42);
        transform.localScale = new Vector2(0.5f, 0.5f);
    }
    private void OnMouseOver()
    {
        transform.localScale = new Vector2(0.51f, 0.51f);
    }
    private void OnMouseExit()
    {
        transform.localScale = new Vector2(0.5f, 0.5f);
    }
    // Update is called once per frame
    void Update () {
		
	}
    public void HowToGame()
    {
        SceneManager.LoadScene("HowtoGame");
    }
}
