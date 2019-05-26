using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class realresult : MonoBehaviour
{
    public Text nameText;
    public Text correct_card;
    public Text wrong_card;
    public Text resultText;
    float[] tt;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("n_inputField") ;
        correct_card.text = PlayerPrefs.GetInt("correct").ToString();
        wrong_card.text = PlayerPrefs.GetInt("wrong").ToString();

        float correct = PlayerPrefs.GetInt("correct");
        float wrong = PlayerPrefs.GetInt("wrong");
        float result = correct / (correct+wrong);
        float score =  result * 100;
        Debug.Log(result);
        Debug.Log(Math.Round(score));
        PlayerPrefs.SetFloat("score", (float)Math.Round(score));
        PlayerPrefs.Save();
        if (result >= 0.7)
        {
           resultText.text = "당신을 진정한 미림인으로 인정합니다 !!!! ♥♥";
        }
        else if (result >= 0.5)
        {
            resultText.text = "미림인이 되기 위해 조금만 더 노력해보세요 :-)";
}
        else
        {
            resultText.text = "미림인이 되기 위해서는 많이 공부하셔야겠군요!! :-( ";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
