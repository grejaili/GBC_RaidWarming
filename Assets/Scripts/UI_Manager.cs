using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    Player player;
    bool paused;
    GameObject comboPointsText;
    int comboCounter=0;



	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
       // comboPointsText = GameObject.FindGameObjectWithTag("ComboPointText");  	
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
        player.currentBulletType = bulletsType.Water;
        Debug.Log("SKill ONe");
       
    }

    public void SelectSkillTwo()
    {
        player.currentBulletType = bulletsType.Earth;
        Debug.Log("SKill two");

    }


    public void SelectSkillThree()
    {
        player.currentBulletType = bulletsType.Fire;
        Debug.Log("SKill three");

    }


    public void SelectSkillFour()
    {
        player.currentBulletType = bulletsType.Wind;
        Debug.Log("SKill Four");

    }

}
