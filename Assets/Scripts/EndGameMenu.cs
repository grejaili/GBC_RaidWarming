using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        GameObject scoreEndGame = GameObject.Find("numbers");
        Debug.Log(scoreEndGame);
        if (scoreEndGame == null)
        {
            return;
        }
        else
        scoreEndGame.GetComponent<Text>().text = score.ToString();
    }

    // Update is called once per frame
    void Update () {
		
	}


    public void RestartGame()
    {
        Debug.Log("hi");
        Application.LoadLevel(1);
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        score = 0;
    }

    public void MainMenu()
    {
        Debug.Log("hi");
        Application.LoadLevel(0);
        score = 0;
    }
    public void quit()
    {
        Debug.Log("hi");
        Application.Quit();
    }

   static public  int score;
   

    [SerializeField]
    GameObject howtoplay;
    public void CloseHowtoPlay()
    {
        Time.timeScale = 1;
        howtoplay.SetActive(false);
    }
}
