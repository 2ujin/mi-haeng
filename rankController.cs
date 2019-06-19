using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.SqliteClient;
using UnityEngine.UI;
using System.IO;
using System.Data;
using System;

public class Rank2
{
    public string ID;
    public string Name;
    public string Score;
    public Rank2(string id, string name, string score)
    { //값을 채워주기 위해서 생성
        ID = id;
        Name = name;
        Score = score;
    }
}
public class rankController : MonoBehaviour
{

    public Text rank1;
    public Text rank2;
    public Text rank3;
    public Text rank4;
    public Text rank5;
    public Text rank6;
    public Text rank7;
    public Text rank8;
    public Text rank9;
    public Text rank10;

    public List<Rank2> RankList = new List<Rank2>();

    void Start()
    {
        StartCoroutine(Main());
    }

    IEnumerator Main()
    {
        yield return StartCoroutine(RankingDbParsing("gamerankdb.sqlite"));
    }

    IEnumerator RankingDbParsing(string p)
    {
        string Filepath = Application.persistentDataPath + "/" + p;

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

                string sqlQuery = "SELECT * FROM GameRankTable ORDER BY Score DESC";


                dbCmd.CommandText = sqlQuery;


                //Debug.Log(dbCmd.CommandText);

                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    while (reader.Read())
                    {
                        //rank1.text =  reader.GetString(0) + "    " + reader.GetString(2);  //  타입명 . (몇 열에있는것을 불를것인가)

                        RankList.Add(new Rank2(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }

           rank1.text = ( RankList[0].Name + "    " + RankList[0].Score + "점");
           rank2.text = (RankList[1].Name + "    " + RankList[1].Score + "점");
           rank3.text = (RankList[2].Name + "    " + RankList[2].Score + "점");
           rank4.text = ( RankList[3].Name + "    " + RankList[3].Score + "점");
           rank5.text = (RankList[4].Name + "    " + RankList[4].Score + "점");
           rank6.text = (RankList[5].Name + "    " + RankList[5].Score + "점");
           rank7.text = ( RankList[6].Name + "    " + RankList[6].Score + "점");
           rank8.text = (RankList[7].Name + "    " + RankList[7].Score + "점");
           rank9.text = (RankList[8].Name + "    " + RankList[8].Score + "점");
           rank10.text = (RankList[9].Name + "    " + RankList[9].Score + "점");

        yield return null;

    }
}