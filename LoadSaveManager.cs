using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Mono.Data.SqliteClient;
using System.IO;
using System.Data;


public class Item
{
    public int ID;
    public string Name;
    public string Des;

    public Item (int id, string name, string des)
    {
        ID = id;
        Name = name;
        Des = des;


    }


}

// Item Db ===> ID, Name, Des     ==>
public class LoadSaveManager : MonoBehaviour {

    public List<Item> ItemList = new List<Item>();

     void Start()
    {

        StartCoroutine(Main());
    }


    IEnumerator Main()
    {
      yield return StartCoroutine(  ItemDbParsing("ItemDb.sqlite"));  // 아이템 정보 파싱. 

   
    }


    // 코루틴 .
    IEnumerator ItemDbParsing(string p)
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


        ItemList.Clear();

        // using을 사용함으로써 비정상적인 예외가 발생할 경우에도 반드시 파일을 닫히도록 할 수 있다.
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())  // EnterSqL에 명령 할 수 있다. 
            {

                string sqlQuery = "SELECT * FROM ItemTable";


                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    while (reader.Read())
                    {
                       // Debug.Log(reader.GetString(1));  //  타입명 . (몇 열에있는것을 불를것인가)
                       
                        ItemList.Add(new Item(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));

                        
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }

        for (int i = 0; i < ItemList.Count; i++)
        {
            Debug.Log(ItemList[i].ID+"::"+ ItemList[i].Name + "::" + ItemList[i].Des);
        }

        yield return null;
    }

    public void SaveBtn()
    {
        StartCoroutine(SaveDb("ItemDb.sqlite"));

    }
    // 코루틴 .
    IEnumerator SaveDb(string p)
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


        ItemList.Clear();

        // using을 사용함으로써 비정상적인 예외가 발생할 경우에도 반드시 파일을 닫히도록 할 수 있다.
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())  // EnterSqL에 명령 할 수 있다. 
            {

              
                //수정
                string ID = "100";
                string Name = "단검";
                string Discription = "단검이다";

                    string sqlQuery = "UPDATE  ItemTable  SET "+ 
                        "Name =" + "'"+Name+"'"
                        + ",Desc =" + "'"+ Discription + "'";

                // string sqlQuery = "INSERT INTO ItemTable  (Name,Desc) VALUES('죽창','죽창이다.')";


                //string sqlQuery = "DELETE FROM ItemTable Where ID =5";
                // WHere을 붙인 이유는 테이블 전체를 돌기 때문에 해당 아이디만 수정하게 선택한것.
                Debug.Log(sqlQuery);
                //UPDATE UserInfo  SET  Money = 11, Scene ='dd', Pos ='0,0,1', Car ='0,0,1'

                dbCmd.CommandText = sqlQuery;
                using (IDataReader reader = dbCmd.ExecuteReader()) // 테이블에 있는 데이터들이 들어간다. 
                {
                    dbConnection.Close();
                    reader.Close();
                }




            }
        }

  

        yield return null;
    }

}
