using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuScript : MonoBehaviour
{

    public string nameInput;
    public int bestScore = 0;
    public TMP_Text bestScoretext;


    // Start is called before the first frame update
    void Start()
    {


        bestScore = 2;
        Debug.Log("Im here");
        bestScoretext.text = "Best Score Name: " + bestScore;
    }


    public void StartButtonPressed()
    {
        Debug.Log("Game Should Start for: "+ nameInput);
        GlobalManager.Instance.playerName = nameInput;
        GlobalManager.Instance.initialScore = bestScore;
        SceneManager.LoadScene(1);
    }

    public void ExitButtonPressed()
    {
        Debug.Log("Game Should Stop");
    }

    public void nameGrabber(string inputName)
    {
        nameInput = inputName;
    }
}
