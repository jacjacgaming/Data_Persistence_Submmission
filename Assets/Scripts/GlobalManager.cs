using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class GlobalManager : MonoBehaviour
{
    public string playerName;
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
}
