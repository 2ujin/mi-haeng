using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class dice : MonoBehaviour {
    Random r = new Random();
    int add = 0;

    public GameObject three;
    public GameObject piece;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void onclickDice(){
        int dice_number = Random.Range(1, 6);
        add += dice_number;
        /*
                SpriteRenderer spr = three.GetComponent<SpriteRenderer>();
                spr.sprite = Resources.Load<Sprite>("three");
                */
        //주사위 모양 바꿔야되는디 골치아푸다
        switch (dice_number) { 
       
            case 1:
                
                break;  
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
        }

        //이제 문제넣어야지
        switch (add)
        {
            // ------------------------보드판 아래쪽----------------------
            case 1: case 25: case 49: // 선도
                piece.transform.position = new Vector3(3.25f, -2.78f, 0f);
                break;
            case 2: case 26: case 50: // 아침청소
                piece.transform.position = new Vector3(1.65f, -2.78f, 0f);
                break;
            case 3: case 27: case 51: //주번활동
                piece.transform.position = new Vector3(0.05f, -2.78f, 0f);
                break;
            case 4: case 28: case 52: //영어회화
                piece.transform.position = new Vector3(-1.55f, -2.78f, 0f);
                break;
            case 5: case 29: case 53: //아침조회
                piece.transform.position = new Vector3(-3.15f, -2.78f, 0f);
                break;
            case 6: case 30: case 54: //징계위원회
                piece.transform.position = new Vector3(-4.75f, -2.78f, 0f);
                break;
            // -----------------------------------------------------------

            // -------------------------보드판 왼쪽------------------------
            case 7: case 31: case 55: //2-1
                piece.transform.position = new Vector3(-4.75f, -1.78f, 0f);
                break;
            case 8: case 32: case 56: // 황금열쇠
                piece.transform.position = new Vector3(-4.75f, -0.7f, 0f);
                break;
            case 9: case 33: case 57: //앱창1실    
                piece.transform.position = new Vector3(-4.75f, 0.2f, 0f);
                break;
            case 10: case 34: case 58: // 인미1실
                piece.transform.position = new Vector3(-4.75f, 1.3f, 0f);
                break;
            case 11: case 35: case 59: // 2-2반
                piece.transform.position = new Vector3(-4.75f, 2.3f, 0f);
                break;  
            case 12: case 36: case 60:// 점심시간
                piece.transform.position = new Vector3(-4.75f, 3.2f, 0f);
                break;
            // ------------------------------------------------------------

            // --------------------------보드판 위쪽-----------------------
            
            case 13: case 37: case 61: //건강달리기
                piece.transform.position = new Vector3(-3.21f, 3.2f, 0f);
                break;
            case 14: case 38: case 62: //체육관
                piece.transform.position = new Vector3(-1.56f, 3.2f, 0f);
                break;
            case 15: case 39: case 63: // 황금열쇠
                piece.transform.position = new Vector3(0.05f, 3.2f, 0f);
                break;
            case 16: case 40: case 64: //청소
                piece.transform.position = new Vector3(1.62f, 3.2f, 0f);
                break;
            case 17: case 41: case 65: //종례
                piece.transform.position = new Vector3(3.3f, 3.2f, 0f);
                break;
            case 18: case 42: case 66: //석식시간
                piece.transform.position = new Vector3(4.9f, -2.78f, 0f);
                break;
            // ------------------------------------------------------------

            // --------------------------보드판 왼쪽-----------------------
            case 19: case 43: case 67: //황금열쇠
                piece.transform.position = new Vector3(4.9f, 2.3f, 0f);
                break;
            case 20: case 44: case 68: //방과후
                piece.transform.position = new Vector3(4.9f, 1.3f, 0f);
                break;
            case 21: case 45: case 69: //매점
                piece.transform.position = new Vector3(4.9f, 0.2f, 0f);
                break;
            case 22: case 46: case 70: // 고시촌
                piece.transform.position = new Vector3(4.9f, -0.8f, 0f);
                break;
            case 23: case 47: case 71: //하교
                piece.transform.position = new Vector3(4.9f, -1.9f, 0f);
                break;

            case 24: case 48:  //교문
                piece.transform.position = new Vector3(4.9f, -2.78f, 0f);
                break;

            if(add >= 72){
                    Debug.Log("게임이 끝났습니당");
            }
                

        }
        Debug.Log(add);

    }

    public void moving()
    {
    }
}
