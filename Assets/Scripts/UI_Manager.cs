using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    //Player player = new player;
    bool paused;
    GameObject comboPointsText;
    int comboCounter=0;



	// Use this for initialization
	void Start () {
        //player = Gameobject.FindGameObjectWithTag("Player");
        comboPointsText = GameObject.FindGameObjectWithTag("ComboPointText");  	
	}
	
    public void Shoot()
    {
        Debug.Log("Call shoot function on player");
    }

    public void PauseButton()
    {
        if (paused == true)
        {
            paused = false;
            Time.timeScale = 1;
        }
        else
        {
            paused = true;
            Time.timeScale = 0;
        }
    }

    public  void UpdateComboPoints()
    {

        comboCounter += 1;
        comboPointsText.GetComponent<Text>().text = comboCounter.ToString();
    }

    public void SelectSkillOne()
    {
        Debug.Log("SKill ONe");
       
    }

    public void SelectSkillTwo()
    {
        Debug.Log("SKill two");

    }


    public void SelectSkillThree()
    {
        Debug.Log("SKill three");

    }


    public void SelectSkillFour()
    {
        Debug.Log("SKill ONe");

    }

}
