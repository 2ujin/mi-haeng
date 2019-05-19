using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class back_btn : MonoBehaviour {
    public GameObject imageObj;
    public Image myimage;
    int count = 0;

    // Use this for initialization
    void Start()
    {
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();
    }
    public void onclickbutton()
    {
        count--;

        switch (count)
        {
            case -1:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_4") as Sprite;
                break;
            case -2:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_3") as Sprite;
                break;
            case -3:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_2") as Sprite;
                break;
            case -4:
                myimage.sprite = Resources.Load<Sprite>("howto/gameguide_1") as Sprite;
                break;
        }
    }
}
