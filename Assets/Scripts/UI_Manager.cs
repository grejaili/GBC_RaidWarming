using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

    Player player;
    bool paused;
    GameObject comboPointsText;
    int comboCounter=0;

	GameObject[] HUD_Skills = new GameObject[4];

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

		for (int i = 0; i < HUD_Skills.Length; i++)
		{
			HUD_Skills[i] = GameObject.Find("HUD_" + ((ElementalType.Element)i).ToString());
			HUD_Skills[i].GetComponentInChildren<Text>().text = ((ElementalType.Element)i).ToString();
			//Debug.Log(((ElementalType.Element)i).ToString());
		}
		
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

    public void UpdateComboPoints()
    {

        comboCounter += 1;
        comboPointsText.GetComponent<Text>().text = comboCounter.ToString();
    }

    public void SelectSkillOne()
    {
        //player.currentBulletType = ;
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
        player.currentBulletType = bulletsType.Air;
        Debug.Log("SKill Four");

    }
	// Workaround for unity's inspector not allowing enums as parameters for a function call...
	// 0 = Fire, 1 = Earth, 2 = Air , 3 = Water
	public void SetBulletType (int newType)
	{
		SetBulletType((ElementalType.Element)newType);
	}

	public void SetBulletType (ElementalType.Element newType)
	{
		player.currentBulletType = (bulletsType)newType;
		Debug.Log("Player's current bullet type: " + player.currentBulletType.ToString());
	}
}
