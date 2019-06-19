using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.SqliteClient;
using UnityEngine.UI;
using System.IO;
using System.Data;
using System;

public class Rank
{
    public int ID;
    public string Name;
    public int Score;
    public Rank(int id, string name, int score){ //값을 채워주기 위해서 생성
        ID = id;
        Name = name;
        Score = score;
    }
}

//rankDB ==> (파싱) ID, NAME, SCORE ==>
public class NewBehaviourScript : MonoBehaviour
{
    public InputField n1;
    public InputField n2;
    public Text text1;
    public Text text2;

    public List<Rank> RankList = new List<Rank>();

    public void miri()
    {
        Debug.Log("ㅇㅎ");
        StartCoroutine(saveDb("rankdb.sqlite"));

        Debug.Log(n1.text);
    }

    IEnumerator Main()
    {
        yield return StartCoroutine(RankingDbParsing("rankdb.sqlite"));
    }

    // 코루틴
    IEnumerator RankingDbParsing(string p)
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


        RankList.Clear();

        // using을 사용함으로써 비정상적인 예외가 발생할 경우에도 반드시 파일을 닫히도록 할 수 있다.
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())  // EnterSqL에 명령 할 수 있다. 
            {

                string sqlQuery = "SELECT * FROM RankTable ORDER BY Score DESC";

                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    while (reader.Read())
                    {
                        Debug.Log(reader.GetString(1));  //  타입명 . (몇 열에있는것을 불를것인가)
                        RankList.Add(new Rank(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
        for (int i = 0; i < RankList.Count; i++)
        {
            Debug.Log(RankList[i].ID + "::" + RankList[i].Name + "::" + RankList[i].Score);
        }

        yield return null;
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


        RankList.Clear();

        // using을 사용함으로써 비정상적인 예외가 발생할 경우에도 반드시 파일을 닫히도록 할 수 있다.
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())  // EnterSqL에 명령 할 수 있다. 
            {

                string sqlQuery = "INSERT INTO RankTable VALUES('5', '" + n1.text + "', '52')";
                
                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    dbConnection.Close();
                    reader.Close();
                }
            }
            for (int i = 0; i < RankList.Count; i++)
            {
                Debug.Log(RankList[i].ID + "::" + RankList[i].Name + "::" + RankList[i].Score);
            }

            yield return null;
        }
    }


}
