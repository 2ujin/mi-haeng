using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
    public GameObject imageObj;
    public Image myimage;
    private Sprite[] diceSides;
    private SpriteRenderer rend;

    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    int count = 0;
    int randomQuestion = 0;
    int secretKeyRandom = 0;


    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();
    }
    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }
    private void OnMouseOver()
    {
    }
    private IEnumerator RollTheDice()
    {

        coroutineAllowed = false;
        int randomDiceSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            myimage.sprite = Resources.Load<Sprite>("Question/back") as Sprite;

            yield return new WaitForSeconds(0.05f);
        }
        // Debug.Log(randomDiceSide + 1);
        count += randomDiceSide + 1;
        Debug.Log(count);

        randomQuestion = Random.Range(1, 4);
        secretKeyRandom = Random.Range(1, 10);
        
        switch (count)
        {
            case 1: case 25: case 49:
                // 선도
                myimage.sprite = Resources.Load<Sprite>("Question/S" + randomQuestion) as Sprite;
                Destroy(myimage, 5);
                Debug.Log("선도");

            break;

            case 2: case 26: case 50:
                myimage.sprite = Resources.Load<Sprite>("Question/MC" + randomQuestion) as Sprite;
                Destroy(myimage, 5);
                Debug.Log("아침청소"); 
            break;

            case 3: case 27: case 51:
                myimage.sprite = Resources.Load<Sprite>("Question/A" + randomQuestion) as Sprite;
                Destroy(myimage, 5);
                Debug.Log("주번활동");
                break;

            case 4: case 28: case 52: //영어회화
                myimage.sprite = Resources.Load<Sprite>("Question/E" + randomQuestion) as Sprite;
                Debug.Log("영어회화");
                break;

            case 5: case 29: case 53: //아침조회
                myimage.sprite = Resources.Load<Sprite>("Question/M" + randomQuestion) as Sprite;
                Debug.Log("아침조회");
                break;

            case 6: case 30: case 54: //징계위원회
                myimage.sprite = Resources.Load<Sprite>("Question/P" + randomQuestion) as Sprite;
                Debug.Log("징계위원회");
                break;

            // -----------------------------------------------------------

            // -------------------------보드판 왼쪽------------------------
            case 7: case 31: case 55: //2-1
                myimage.sprite = Resources.Load<Sprite>("Question/FI" + randomQuestion) as Sprite;
                Debug.Log("3-1");
                break;
            case 8: case 32: case 56: // 황금열쇠
                Debug.Log("황금열쇠");
                myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
                break;
            case 9: case 33: case 57: //앱창1실    
                myimage.sprite = Resources.Load<Sprite>("Question/EC" + randomQuestion) as Sprite;
                Debug.Log("영어카페");
                break;
            case 10: case 34: case 58: // 인미1실
                myimage.sprite = Resources.Load<Sprite>("Question/CR" + randomQuestion) as Sprite;
                Debug.Log("커리어존");
                break;
            case 11: case 35: case 59: // 2-2반
                myimage.sprite = Resources.Load<Sprite>("Question/SE" + randomQuestion) as Sprite;
                Debug.Log("3-2");
                break;
            case 12: case 36: case 60:// 점심시간
                myimage.sprite = Resources.Load<Sprite>("Question/L" + randomQuestion) as Sprite;
                Debug.Log("점심시간");
                break;
            // ------------------------------------------------------------

            // --------------------------보드판 위쪽-----------------------

            case 13: case 37: case 61: //건강달리기
                myimage.sprite = Resources.Load<Sprite>("Question/H" + randomQuestion) as Sprite;
                Debug.Log("건달");
                break;
            case 14: case 38: case 62: //체육관
                myimage.sprite = Resources.Load<Sprite>("Question/G" + randomQuestion) as Sprite;
                Debug.Log("체육관");
                break;
            case 15: case 39: case 63: // 황금열쇠
                myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
                Debug.Log("황금열쇠");
                break;
            case 16: case 40: case 64: //청소
                myimage.sprite = Resources.Load<Sprite>("Question/C" + randomQuestion) as Sprite;
                Debug.Log("청소");
                break;
            case 17: case 41: case 65: //종례
                myimage.sprite = Resources.Load<Sprite>("Question/END" + randomQuestion) as Sprite;
                Debug.Log("종례");
                break;
            case 18: case 42: case 66: //석식시간
                myimage.sprite = Resources.Load<Sprite>("Question/DI" + randomQuestion) as Sprite;
                Debug.Log("석식시간");
                break;
            // ------------------------------------------------------------

            // --------------------------보드판 왼쪽-----------------------
            case 19: case 43: case 67: //황금열쇠
                myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
                Debug.Log("황금열쇠");
                break;
            case 20: case 44: case 68: //방과후
                myimage.sprite = Resources.Load<Sprite>("Question/AF" + randomQuestion) as Sprite;
                Debug.Log("방과후");
                break;
            case 21: case 45: case 69: //매점
                myimage.sprite = Resources.Load<Sprite>("Question/ST" + randomQuestion) as Sprite;
                Debug.Log("매점");
                break;
            case 22: case 46: case 70: // 고시촌
                myimage.sprite = Resources.Load<Sprite>("Question/GO" + randomQuestion) as Sprite;
                Debug.Log("고시촌");
                break;
            case 23: case 47: case 71: //하교
                myimage.sprite = Resources.Load<Sprite>("Question/HO" + randomQuestion) as Sprite;
                Debug.Log("하교");
                break;

            case 24: case 48:  //교문
                myimage.sprite = Resources.Load<Sprite>("Question/D" + randomQuestion) as Sprite;
                Debug.Log("교문");
                break;
        }

        if (count >= 72)
        {
            Debug.Log("끝났슴당");
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        coroutineAllowed = true;
    }
}