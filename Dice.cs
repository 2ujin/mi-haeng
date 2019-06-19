using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Dice : MonoBehaviour
{
    public GameObject imageObj;
    public Image myimage;
    public Image myimage1;

    private Sprite[] diceSides;
    private SpriteRenderer rend;

    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    int count = 0;
    int dice = 0;
    public int countCandy = 0;
    public int countChoco = 0;
    int randomQuestion = 0;
    int secretKeyRandom = 0;
    int secretKeyRandom1 = 0;
    int secretKeyRandom2 = 0;
    private GameObject player1;

    private void Start()
    {
        //transform.localPosition = new Vector2(101, -79);
        //transform.localScale = new Vector2(0.5f, 0.5f);
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
    IEnumerator sundo()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().sundo();
    }
    IEnumerator morning()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().morning();
    }
    IEnumerator jubun()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().jubun();
    }
    IEnumerator english()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().english();
    }
    IEnumerator achim()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().achim();
    }
    IEnumerator punish()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().punish();
    }
    IEnumerator firstclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().firstclass();
    }
    IEnumerator secondclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().secondclass();
    }
    IEnumerator thirdclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().thirdclass();
    }
    IEnumerator fourthclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().fourthclass();
    }
    IEnumerator lunch()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().lunch();
    }
    IEnumerator fiveclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().fiveclass();
    }
    IEnumerator sixclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().sixclass();
    }
    IEnumerator sevenclass()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().sevenclass();
    }
    IEnumerator finishschool()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().finishschool();
    }
    IEnumerator dinner()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().dinner();
    }
    IEnumerator afterschool()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().afterschool();
    }
    IEnumerator store()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().store();
    }
    IEnumerator gosi()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().gosi();
    }
    IEnumerator gohome()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().gohome();
    }
    IEnumerator door()
    {
        yield return new WaitForSeconds(6);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().door();
    }
    IEnumerator secretKey_add1() // 상점 3
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().secretKey_add1();
    }
    IEnumerator SecretKey_add2() // 상점 2
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().SecretKey_add2();
    }
    IEnumerator SecretKey_add3() // 상점 1
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().SecretKey_add3();
    }
    IEnumerator SecretKey_minus1()
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().SecretKey_minus1();
    }
    IEnumerator SecretKey_minus2()
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().SecretKey_minus2();
    }
    IEnumerator SecretKey_minus3()
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
        GameObject.FindWithTag("GameController").GetComponent<pratice>().SecretKey_minus3();
    }
    IEnumerator SecretKey()
    {
        yield return new WaitForSeconds(3);//WaitForSeconds객체를 생성해서 반환
    }
    IEnumerator dissapear1()
    {
        yield return new WaitForSeconds(4);//WaitForSeconds객체를 생성해서 반환
        myimage.sprite = Resources.Load<Sprite>("Question/back") as Sprite;
    }
        IEnumerator dissapear()
    {
        yield return new WaitForSeconds(7);//WaitForSeconds객체를 생성해서 반환
        myimage.sprite = Resources.Load<Sprite>("Question/back") as Sprite; 
    }
    IEnumerator gameover()
    {
        myimage.sprite = Resources.Load<Sprite>("Question/gameover_1") as Sprite; ;
        yield return new WaitForSeconds(2);//WaitForSeconds객체를 생성해서 반환
        SceneManager.LoadScene("nameInput");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;

        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 4);
            rend.sprite = diceSides[randomDiceSide];
            myimage.sprite = Resources.Load<Sprite>("Question/back") as Sprite;

            yield return new WaitForSeconds(0.05f);
        }
        // Debug.Log(randomDiceSide + 1);
        count += randomDiceSide + 1;
        dice++;

        randomQuestion = Random.Range(1, 3);

        //첫번째 황금열쇠 (문제)
        PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
        PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);

        if (count == 1)
        { //선도
            myimage.sprite = Resources.Load<Sprite>("Question/S" + randomQuestion) as Sprite;
            StartCoroutine(sundo());
            StartCoroutine(dissapear());
        }
        else if (count == 2) //아침청소
        {
            myimage.sprite = Resources.Load<Sprite>("Question/MC" + randomQuestion) as Sprite;
            StartCoroutine(morning());
            StartCoroutine(dissapear());
        }
        else if (count == 3 ) //주번활동
        {
            myimage.sprite = Resources.Load<Sprite>("Question/A" + randomQuestion) as Sprite;
            StartCoroutine(jubun());
            StartCoroutine(dissapear());
        }
        else if (count == 4) //영어회화
        {
            myimage.sprite = Resources.Load<Sprite>("Question/E" + randomQuestion) as Sprite;
            StartCoroutine(english());
            StartCoroutine(dissapear());
        }
        else if (count == 5) //아침조회
        {
            myimage.sprite = Resources.Load<Sprite>("Question/M" + randomQuestion) as Sprite;
            StartCoroutine(achim());
            StartCoroutine(dissapear());
        }
        else if (count == 6 ) //징계위원회
        {
            myimage.sprite = Resources.Load<Sprite>("Question/P" + randomQuestion) as Sprite;
            StartCoroutine(punish());
            StartCoroutine(dissapear());
        }
        // -------------------------------------------------------------------------------------
        else if (count == 7 ) //2-1 1교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/FI" + randomQuestion) as Sprite;
            StartCoroutine(firstclass());
            StartCoroutine(dissapear());
        }
        // *** 수정필요
        else if (count == 8) //황금열쇠 
        {
            Debug.Log(secretKeyRandom);
            secretKeyRandom = Random.Range(1, 13);
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + secretKeyRandom) as Sprite;
            if(secretKeyRandom == 1) { 
                    StartCoroutine(SecretKey());
                    countChoco++;
                    PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                    StartCoroutine(dissapear1());
            }
            else if(secretKeyRandom == 2)// 사탕 2개
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 3) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 4) // 상점 +3점
            {
                StartCoroutine(secretKey_add1());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 5) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 6) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 7) // 상점 +2
            {
                StartCoroutine(SecretKey_add2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 8) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 9) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 10) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 11) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 12) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
        }
        else if (count == 9 ) //앱창1실 2교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/EC" + randomQuestion) as Sprite;
            StartCoroutine(secondclass());
            StartCoroutine(dissapear());
        }
        else if (count == 10) //인미1실 3교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/CR" + randomQuestion) as Sprite;
            StartCoroutine(thirdclass());
            StartCoroutine(dissapear());
        }
        else if (count == 11) //2-2 4교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/SE" + randomQuestion) as Sprite;
            StartCoroutine(fourthclass());
            StartCoroutine(dissapear());
        }
        else if (count == 12) //점심시간
        {
            myimage.sprite = Resources.Load<Sprite>("Question/L" + randomQuestion) as Sprite;
            StartCoroutine(lunch());
            StartCoroutine(dissapear());
        }
        // ----------------------------------------------------------------------------
        else if (count == 13) //건강달리기 5교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/H" + randomQuestion) as Sprite;
            StartCoroutine(fiveclass());
            StartCoroutine(dissapear());
        }
        else if (count == 14) //체육관 6교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/G" + randomQuestion) as Sprite;
            StartCoroutine(sixclass());
            StartCoroutine(dissapear());
        }
        else if (count == 15) //황금열쇠 - 상점
        {
            Debug.Log(secretKeyRandom);
            secretKeyRandom = Random.Range(1, 13);
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + secretKeyRandom) as Sprite;
            if (secretKeyRandom == 1)
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 2)// 사탕 2개
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 3) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 4) // 상점 +3점
            {
                StartCoroutine(secretKey_add1());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 5) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 6) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 7) // 상점 +2
            {
                StartCoroutine(SecretKey_add2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 8) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 9) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 10) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 11) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 12) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
        }
        else if (count == 16) //청소 7교시
        {
            myimage.sprite = Resources.Load<Sprite>("Question/C" + randomQuestion) as Sprite;
            StartCoroutine(sevenclass());
            StartCoroutine(dissapear());
        }
        else if (count == 17) //종례
        {
            myimage.sprite = Resources.Load<Sprite>("Question/END" + randomQuestion) as Sprite;
            StartCoroutine(finishschool());
            StartCoroutine(dissapear());
        }
        else if (count == 18) //석식시간
        {
            myimage.sprite = Resources.Load<Sprite>("Question/DI" + randomQuestion) as Sprite;
            StartCoroutine(dinner());
            StartCoroutine(dissapear());
        }
        // ----------------------------------------------------------------------------

        else if (count == 19) //황금열쇠
        {
            secretKeyRandom = Random.Range(1, 13);
            myimage.sprite = Resources.Load<Sprite>("Question/SK" + secretKeyRandom) as Sprite;
            if (secretKeyRandom == 1)
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 2)// 사탕 2개
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 3) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 4) // 상점 +3점
            {
                StartCoroutine(secretKey_add1());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 5) // 초코파이
            {
                StartCoroutine(SecretKey());
                countChoco++;
                PlayerPrefs.SetString("choco", "초코파이  x  " + countChoco);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 6) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 7) // 상점 +2
            {
                StartCoroutine(SecretKey_add2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 8) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 9) // 사탕
            {
                StartCoroutine(SecretKey());
                countCandy = countCandy + 2;
                PlayerPrefs.SetString("candy", "사탕  x  " + countCandy);
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 10) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 11) // 벌점 -2
            {
                StartCoroutine(SecretKey_minus2());
                StartCoroutine(dissapear1());
            }
            else if (secretKeyRandom == 12) // 벌점 -3
            {
                StartCoroutine(SecretKey_minus3());
                StartCoroutine(dissapear1());
            }
        }
        else if (count == 20) //방과후
        {
            myimage.sprite = Resources.Load<Sprite>("Question/AF" + randomQuestion) as Sprite;
            StartCoroutine(afterschool());
            StartCoroutine(dissapear());
        }
        else if (count == 21) //매점
        {
            myimage.sprite = Resources.Load<Sprite>("Question/ST" + randomQuestion) as Sprite;
            StartCoroutine(store());
            StartCoroutine(dissapear());
        }
        else if (count == 22) //고시촌
        {
            myimage.sprite = Resources.Load<Sprite>("Question/GO" + randomQuestion) as Sprite;
            StartCoroutine(gosi());
            StartCoroutine(dissapear());
        }
        else if (count == 23) //하교
        {
            myimage.sprite = Resources.Load<Sprite>("Question/HO" + randomQuestion) as Sprite;
            StartCoroutine(gohome());
            StartCoroutine(dissapear());
        }
        else if (count == 24) //교문
        {
            myimage.sprite = Resources.Load<Sprite>("Question/D" + randomQuestion) as Sprite;
            StartCoroutine(door());
            StartCoroutine(dissapear());
        }
        if (count >= 24)
        {
            GameObject.FindWithTag("GameController").GetComponent<pratice>().hidden();
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