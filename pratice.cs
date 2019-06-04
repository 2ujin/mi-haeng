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
        transform.localPosition = new Vector2(350f, -270);
        transform.localScale = new Vector2(1.5f, 1.5f);
        imageObj1 = GameObject.FindGameObjectWithTag("Player");
        myimage1 = imageObj1.GetComponent<Image>();
        CountText.GetComponent<Text>();
        CountText1.GetComponent<Text>();
    }

    public void sundo()
    {
            Debug.Log("입력한 값 : " + m_inputField.text);
            int answer = 5;
            if (m_inputField.text == answer.ToString())
            {
                StartCoroutine(add());
                myimage1.sprite = Resources.Load<Sprite>("Question/add") as Sprite;
                m_inputField.text = null;
                correct++;
                CountText.text = "" + correct;
                PlayerPrefs.SetInt("correct", int.Parse(CountText.text));
            }
            else
            {
                StartCoroutine(minus());
                m_inputField.text = null;
                wrong++;
                CountText1.text = "" + wrong;
                PlayerPrefs.SetInt("wrong", int.Parse(CountText1.text));
        }
    }
    public void morning()
    {
        int answer = 4;
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
    public void jubun()
    {
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
    public void english()
    {
        int answer = 1;
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
    public void achim()
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
    public void punish()
    {
        int answer = 5;
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
    public void firstclass()
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
    public void secondclass()
    {
        int answer = 1;
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
    public void thirdclass()
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
    public void fourthclass()
    {
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
    public void lunch()
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
    public void fiveclass()
    {
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
    public void sixclass()
    {
        int answer = 5;
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
    public void sevenclass()
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
    public void finishschool()
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
    public void dinner()
    {
        int answer = 1;
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
    public void afterschool()
    {
        int answer = 5;
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
    public void store()
    {
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
    public void gosi()
    {
        int answer = 4;
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
    public void gohome()
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
    public void door()
    {
        int answer = 1;
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
    public void secretKey()
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
    public void secretKey_add1() // 상점 +3
    {
        int il = correct + 3;
        CountText.text = "" + il;
    }
    public void SecretKey_add2() // 상점 +2
    {
        int il = correct + 2;
        CountText.text = "" + il;
    }
    public void SecretKey_add3() // 상점 +1
    {
        int il = correct + 1;
        CountText.text = "" + il;
    }

    public void SecretKey_minus1() // 벌점 -1
    {
        int il1 = wrong + 1;
        CountText1.text = "" + il1;
    }
    public void SecretKey_minus2() // 벌점 -1
    {
        int il1 = wrong + 1;
        CountText1.text = "" + il1;
    }
    public void SecretKey_minus3() // 벌점 -2
    {
        int il1 = wrong + 2;
        CountText1.text = "" + il1;
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
