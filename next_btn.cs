using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class next_btn : MonoBehaviour {
    public GameObject imageObj;
    public Image myimage;
    public static int count = 2;
    int set = 0;
	// Use this for initialization
	void Start () {
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();

        //transform.localPosition = new Vector2(520, -485);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }

    public void onclickbutton1() // 다음버튼
    {
        myimage.sprite = Resources.Load<Sprite>("howto/gameguide_" + count) as Sprite;
        count++;
        if(count >= 6)
        {
            myimage.sprite = Resources.Load<Sprite>("howto/gameguide_5") as Sprite;
            count = 5;
        }
    }
    
    public void onclickbutton() // 이전버튼
    {
        count--;
        myimage.sprite = Resources.Load<Sprite>("howto/gameguide_" + count) as Sprite;

        if (count <= 0)
        {
            myimage.sprite = Resources.Load<Sprite>("howto/gameguide_1") as Sprite;
            count = 1;
        }
    }


}
