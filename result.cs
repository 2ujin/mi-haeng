using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public InputField n_inputField;
    public Text n_text;
    public InputField n1_inputField;
    public Text n1_text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void OnClickButton()
    {    
        SceneManager.LoadScene("result");
        Debug.Log(n_inputField.text);
        Debug.Log(n1_inputField.text);
    }
    public void text()
    {

    }
}
