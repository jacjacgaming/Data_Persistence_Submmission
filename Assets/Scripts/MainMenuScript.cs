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
    public GameObject scorePanel;




    // Start is called before the first frame update
    void Start()
    {
        GlobalManager.Instance.loadData();
        bestScore = GlobalManager.Instance.playerHighScore;
        nameInput = GlobalManager.Instance.playerName;
        
        Debug.Log("Im here");
        nameInput = GlobalManager.Instance.playerName;
        bestScoretext.text = "Best Score "+ nameInput+ " : "+bestScore;


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

    public void scoresButtonPressed()
    {
        if (!scorePanel.activeInHierarchy)
        {
            scorePanel.SetActive(true);
        }
        else
        {
            scorePanel.SetActive(false);
        }
        //scorePanel.SetActive(false);
    }


}
