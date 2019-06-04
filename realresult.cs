using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.SqliteClient;
using UnityEngine.UI;
using System.IO;
using System.Data;
using System;
public class rank
{
    public int ID;
    public string Name;
    public double Score;

    public rank(int id, string name, double score)
    {
        ID = id;
        Name = name;
        Score = score;
    }
}

public class realresult : MonoBehaviour
{
    public Text nameText;
    public Text correct_card;
    public Text wrong_card;
    public Text resultText;

    private double Score = 0;
    private double savedScore = 0;

    public List<rank> rankList = new List<rank>();

    void Start()
    {
        nameText.text = PlayerPrefs.GetString("name") ;

        correct_card.text = PlayerPrefs.GetInt("correct").ToString();
        wrong_card.text = PlayerPrefs.GetInt("wrong").ToString();

        double correct = PlayerPrefs.GetInt("correct");
        double wrong = PlayerPrefs.GetInt("wrong");
        double result = correct / (correct+wrong);
        Score =  result * 100;

        PlayerPrefs.SetString("justscore", Score.ToString("0"));

        Debug.Log(PlayerPrefs.GetString("justscore"));

        StartCoroutine(saveDb("rankdb.sqlite"));

        if (result >= 0.7)
        {
           resultText.text = "당신을 진정한 미림인으로 인정합니다 !!!! ♥♥";
        }
        else if (result >= 0.5)
        {
            resultText.text = "미림인이 되기 위해 조금만 더 노력해보세요 :-)";
}
        else
        {
            resultText.text = "미림인이 되기 위해서는 많이 공부하셔야겠군요!! :-( ";
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
                Debug.Log("됐다리");
                string sqlQuery = "INSERT INTO RankTable VALUES('" + PlayerPrefs.GetString("number") + " ', '" + PlayerPrefs.GetString("name") + "','" + PlayerPrefs.GetString("justscore") + "')";
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
