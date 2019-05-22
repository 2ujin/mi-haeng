using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pratice : MonoBehaviour
{
    public GameObject imageObj;
    public InputField m_inputField;
    public Text m_text;
    public Image myimage;
    public int correct = 0;
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GameObject.FindGameObjectWithTag("Player");
        myimage = imageObj.GetComponent<Image>();

        
    }

    // Update is called once per frame
    void Update()
    {
        sundo();
    }
    public void sundo()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int answer = 3;
            if(m_inputField.text == answer.ToString())
            {
                StartCoroutine(Example());
                Debug.Log("정답");
                m_inputField.text = null;
                
                
                Destroy(myimage, 1);
                correct++;
            }
            else
            {
                Debug.Log("정답이 아님 ㅠㅠ");
                m_inputField.text = null;
                myimage.sprite = Resources.Load<Sprite>("Question/minus") as Sprite;
                Destroy(myimage, 1);
            }
        }
    }
    IEnumerator Example()
    {
        myimage.sprite = Resources.Load<Sprite>("Question/add") as Sprite;
        yield return new WaitForSeconds(2);//WaitForSeconds객체를 생성해서 반환
        myimage.sprite = Resources.Load<Sprite>("Question/image") as Sprite;
    }
    public void morning()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int answer = 3;
            if (m_inputField.text == answer.ToString())
            {
                Debug.Log("정답");
                m_inputField.text = null;
                myimage.sprite = Resources.Load<Sprite>("Question/add") as Sprite;
                Destroy(myimage, 1);
            }
            else
            {
                Debug.Log("정답이 아님 ㅠㅠ");
                m_inputField.text = null;
                myimage.sprite = Resources.Load<Sprite>("Question/minus") as Sprite;
                Destroy(myimage, 1);
            }
        }
    }
}
