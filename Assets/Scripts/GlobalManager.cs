using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using System.IO;

public class GlobalManager : MonoBehaviour
{
    public string playerName;
    public string highScorePlayerName = "juanito";
    public int playerHighScore;
    public int initialScore;
    public static GlobalManager Instance;


    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }


        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    class SaveData
    {
        public string playerName;
        public int playerHighScore;
        public string hsPlayerName;

    }

    public void saveData()
    {
        SaveData data = new SaveData();

        data.playerName = playerName;
        data.playerHighScore = playerHighScore;
        data.hsPlayerName = highScorePlayerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void loadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        
        if (File.Exists(path))
        {
            Debug.Log("I found the save");
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerHighScore = data.playerHighScore;
            playerName = data.playerName;
            highScorePlayerName = data.hsPlayerName;
        }
    }
}
