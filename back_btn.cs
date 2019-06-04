using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class back_btn : MonoBehaviour {
    public GameObject imageObj;
    public Image myimage;
    int count = 2;

    // Use this for initialization
    void Start()
    {
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();
        //transform.localPosition = new Vector2(-520, -485);
        transform.localScale = new Vector2(1.5f, 1.5f);
    }
    public void onclickbutton()
    {
        count--;
        myimage.sprite = Resources.Load<Sprite>("howto/gameguide_" + count) as Sprite;
        count--;
    }
}
