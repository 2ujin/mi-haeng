using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.SqliteClient;
using System.IO;
using System.Data;

public class rank
{
    public string ID;
    public string Name;
    public string Score;

    public rank(string id, string name, string score)
    {
        ID = id;
        Name = name;
        Score = score;
    }
}

public class realresult : MonoBehaviour
{
    public GameObject imageobj;
    public Text nameText;
    public Text correct_card;
    public Text wrong_card;
    public Text resultText;
    public Text choco;
    public Text candy;
    public Image resultImg;

    private double Score = 0;
    private double savedScore = 0;

    public List<rank> rankList = new List<rank>();

    System.DateTime time = System.DateTime.Now;
    
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("name") ;
        correct_card.text = PlayerPrefs.GetInt("correct").ToString();
        wrong_card.text = PlayerPrefs.GetInt("wrong").ToString();

        choco.text = PlayerPrefs.GetString("choco");
        candy.text = PlayerPrefs.GetString("candy");

        double correct = PlayerPrefs.GetInt("correct");
        double wrong = PlayerPrefs.GetInt("wrong");
        double result = correct / (correct+wrong);
        Score =  result * 100;

        PlayerPrefs.SetString("justscore", Score.ToString("0"));

        //Debug.Log(PlayerPrefs.GetString("justscore"));

        imageobj = GameObject.FindGameObjectWithTag("Finish");
        resultImg = imageobj.GetComponent<Image>();
        resultImg.sprite = Resources.Load<Sprite>("Question/bad") as Sprite;
        StartCoroutine(saveDb("gamerankdb.sqlite"));

        if (result >= 0.7) // 70퍼 이상
        {
            resultImg.sprite = Resources.Load<Sprite>("Question/best") as Sprite;
        }
        else if (result >= 0.5) //50퍼 이상
        {
            resultImg.sprite = Resources.Load<Sprite>("Question/soso") as Sprite;
        }
        else
        {
            resultImg.sprite = Resources.Load<Sprite>("Question/bad") as Sprite;
        }
    }

    private IEnumerator saveDb(string p)
    {
        string Filepath = Application.persistentDataPath + "/" + p; //캐시메모리

        if (!File.Exists(Filepath))
        {
            Debug.LogWarning("File \"" + Filepath + "\" does not exist. Attempting to create from \"" +
                             Application.dataPath + "!/assets/" + p);

            WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/" + p);
            while (!loadDB.isDone) { }
            File.WriteAllBytes(Filepath, loadDB.bytes);
        }

        string connectionString = "URI=file:" + Filepath;

        rankList.Clear();

        // using을 사용함으로써 비정상적인 예외가 발생할 경우에도 반드시 파일을 닫히도록 할 수 있다.
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())  // EnterSqL에 명령 할 수 있다. 
            {
                string sqlQuery = "INSERT INTO GameRankTable VALUES('" + PlayerPrefs.GetString("number") + " ', '" + PlayerPrefs.GetString("name") + "','" + PlayerPrefs.GetString("justscore") +
                    "','" + PlayerPrefs.GetString("choco") + "','" + PlayerPrefs.GetString("candy") + "','" + time.ToString("hh:mm tt") + "')";
                //string sqlQuery = "SELECT * FROM RankTable ORDER BY Score DESC";

                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    dbConnection.Close();
                    reader.Close();
                }
            }
            yield return null;
        }
    }
}
