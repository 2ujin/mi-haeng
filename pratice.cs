using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pratice : MonoBehaviour
{
    public GameObject imageObj1;
    public InputField m_inputField;
    public Text m_text;
    public Image myimage1;
    public int correct = 0;
    public int wrong = 0;
    public Text CountText;
    public Text CountText1;

    // Start is called before the first frame update
    void Start()
    {
        imageObj1 = GameObject.FindGameObjectWithTag("Player");
        myimage1 = imageObj1.GetComponent<Image>();
        CountText.GetComponent<Text>();
        CountText1.GetComponent<Text>();
    }

    public void sundo()
    {
        Debug.Log(m_inputField.text);
            int answer = 3;
            if (m_inputField.text == answer.ToString())
            {
                StartCoroutine(add());
                myimage1.sprite = Resources.Load<Sprite>("Question/add") as Sprite;
                m_inputField.text = null;
                correct++;
                CountText.text = "" + correct;
            }
            else
            {
                StartCoroutine(minus());
                m_inputField.text = null;
                wrong++;
                CountText1.text = "" + wrong;
            }
    }
    public void sundo1()
    {
        int answer = 2;
        if (m_inputField.text == answer.ToString())
        {
            StartCoroutine(add());
            myimage1.sprite = Resources.Load<Sprite>("Question/add") as Sprite;
            m_inputField.text = null;
            correct++;
            CountText.text = "" + correct;
        }
        else
        {
            StartCoroutine(minus());
            m_inputField.text = null;
            wrong++;
            CountText1.text = "" + wrong;
        }
    }
    public void hi()
    {
        Debug.Log("안녕 ㅎㅎ");
    }
    IEnumerator add()
    {
        
        yield return new WaitForSeconds(1);//WaitForSeconds객체를 생성해서 반환
        myimage1.sprite = Resources.Load<Sprite>("Question/image") as Sprite;
    }
    IEnumerator minus()
    {
        myimage1.sprite = Resources.Load<Sprite>("Question/minus") as Sprite;
        yield return new WaitForSeconds(1);//WaitForSeconds객체를 생성해서 반환
        myimage1.sprite = Resources.Load<Sprite>("Question/image") as Sprite;
    }
}
