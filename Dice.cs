using UnityEngine.SceneManagement;
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
    int dice = 0;
    int randomQuestion = 0;
    int secretKeyRandom = 0;


    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
        imageObj = GameObject.FindGameObjectWithTag("Finish");
        myimage = imageObj.GetComponent<Image>();
        pratice sondo = GameObject.FindWithTag("GameController").GetComponent<pratice>();
    }
    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }
    IEnumerator add1()
    {
        yield return new WaitForSeconds(4);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().sundo();
    }
    IEnumerator morning()
    {
        yield return new WaitForSeconds(4);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().sundo();
    }
    IEnumerator dissapear()
    {
        yield return new WaitForSeconds(5);//WaitForSeconds객체를 생성해서 반환
        myimage.sprite = Resources.Load<Sprite>("Question/back") as Sprite; ;
    }
    IEnumerator gameover()
    {
        myimage.sprite = Resources.Load<Sprite>("Question/gameover") as Sprite; ;
        yield return new WaitForSeconds(2);//WaitForSeconds객체를 생성해서 반환
        SceneManager.LoadScene("nameInput");
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
        dice++;
        //Debug.Log("주사위 누른 횟수 : " + dice);

        randomQuestion = Random.Range(1, 4);
        secretKeyRandom = Random.Range(1, 10);

        if (count == 1 || count == 25 || count == 49) { //선도
           myimage.sprite = Resources.Load<Sprite>("Question/S" + randomQuestion) as Sprite;
           StartCoroutine(add1());
           StartCoroutine(dissapear());
        }
        else if (count == 2 || count == 26 || count == 50) //아침청소
        {
            myimage.sprite = Resources.Load<Sprite>("Question/MC" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 3 || count == 27 || count == 51) //주번활동
        {
            myimage.sprite = Resources.Load<Sprite>("Question/A" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 4 || count == 28 || count == 52) //영어회화
        {
            myimage.sprite = Resources.Load<Sprite>("Question/E" + randomQuestion) as Sprite;
            StartCoroutine(morning());
            StartCoroutine(dissapear());
        }
        else if (count == 5 || count == 29 || count == 53) //아침조회
        {
            myimage.sprite = Resources.Load<Sprite>("Question/M" + randomQuestion) as Sprite;
            StartCoroutine(morning());
            StartCoroutine(dissapear());
        }
        else if (count == 6 || count == 30 || count == 54) //징계위원회
        {
            myimage.sprite = Resources.Load<Sprite>("Question/P" + randomQuestion) as Sprite;
            StartCoroutine(morning());
            StartCoroutine(dissapear());
        }
        // -------------------------------------------------------------------------------------
        else if (count == 7 || count == 31 || count == 55) //2-1
        {
            myimage.sprite = Resources.Load<Sprite>("Question/FI" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 8 || count == 32 || count == 56) //황금열쇠
        {
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 9 || count == 33 || count == 57) //앱창1실
        {
            myimage.sprite = Resources.Load<Sprite>("Question/EC" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 10 || count == 34 || count == 58) //인미1실
        {
            myimage.sprite = Resources.Load<Sprite>("Question/CR" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 11 || count == 35 || count == 59) //2-2
        {
            myimage.sprite = Resources.Load<Sprite>("Question/SE" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 12 || count == 36 || count == 60) //점심시간
        {
            myimage.sprite = Resources.Load<Sprite>("Question/L" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        // ----------------------------------------------------------------------------
        else if (count == 13 || count == 37 || count == 61) //건강달리기
        {
            myimage.sprite = Resources.Load<Sprite>("Question/H" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 14 || count == 38 || count == 62) //체육관
        {
            myimage.sprite = Resources.Load<Sprite>("Question/G" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 15 || count == 39 || count == 63) //황금열쇠
        {
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 16 || count == 40 || count == 64) //청소
        {
            myimage.sprite = Resources.Load<Sprite>("Question/C" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 17 || count == 41 || count == 65) //종례
        {
            myimage.sprite = Resources.Load<Sprite>("Question/END" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 18 || count == 42 || count == 66) //석식시간
        {
            myimage.sprite = Resources.Load<Sprite>("Question/DI" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        // ----------------------------------------------------------------------------
        else if (count == 19 || count == 43 || count == 67) //황금열쇠
        {
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 20 || count == 44 || count == 68) //방과후
        {
            myimage.sprite = Resources.Load<Sprite>("Question/AF" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 21 || count == 45 || count == 69) //매점
        {
            myimage.sprite = Resources.Load<Sprite>("Question/ST" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 22 || count == 46 || count == 70) //고시촌
        {
            myimage.sprite = Resources.Load<Sprite>("Question/GO" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 23 || count == 47 || count == 71) //하교
        {
            myimage.sprite = Resources.Load<Sprite>("Question/HO" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        else if (count == 24 || count == 48) //교문
        {
            myimage.sprite = Resources.Load<Sprite>("Question/D" + randomQuestion) as Sprite;
            StartCoroutine(add1());
            StartCoroutine(dissapear());
        }
        if (count >= 20)
        {
            StartCoroutine(gameover());
        }
        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        coroutineAllowed = true;
    }
}