using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class realresult : MonoBehaviour
{
    public Text nameText;
    // Start is called before the first frame update
    void Start()
    {
        result r = GameObject.FindWithTag("Finish").GetComponent<result>();

        nameText.text = "3"  + r.n_inputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
