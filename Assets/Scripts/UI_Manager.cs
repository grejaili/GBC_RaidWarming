using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour {

	public uint specialThreshold;
	private int comboCounter = 0;
	private bool paused;

	private Player player;
	private GameObject HUD_ComboCounter;
	private GameObject[] HUD_Skills = new GameObject[4];

	public static UI_Manager _instance = null;
	public static UI_Manager instance
	{
		get { return _instance; }
		set { _instance = value; }
	}

	// Use this for initialization
	void Start ()
	{
		if (instance)
		{
			DestroyImmediate(gameObject);
		}
		else
		{
			instance = this;

			DontDestroyOnLoad(this);
		}

		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		HUD_ComboCounter = GameObject.Find("HUD_Combo");
		HUD_ComboCounter.GetComponent<Text>().text = "";
		for (int i = 0; i < HUD_Skills.Length; i++)
		{
			HUD_Skills[i] = GameObject.Find("HUD_" + ((ElementalType.Element)i).ToString());
			HUD_Skills[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.3f);
			//HUD_Skills[i].GetComponentInChildren<Text>().text = ((ElementalType.Element)i).ToString();
			//Debug.Log(((ElementalType.Element)i).ToString());
		}
		
		if(specialThreshold == 0)
		{
			Debug.Log("specialThreshold not set in inspector, defaulting to 6");
			specialThreshold = 6;
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

    public static void UpdateComboPoints()
    {
		if (instance && instance.HUD_ComboCounter.GetComponent<Text>())
		{
			string comboStatus = " Hit Combo!";
			instance.comboCounter += 1;
			instance.HUD_ComboCounter.GetComponent<Text>().text = instance.comboCounter.ToString() + comboStatus;
		}
		if (instance.comboCounter % instance.specialThreshold == 0)
		{
			Debug.Log("Some kinda special shit should happen.");
		}
    }

	public static void ResetComboPoints()
	{
		instance.HUD_ComboCounter.GetComponent<Text>().text = "";
		instance.comboCounter = 0;
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

		Color transparent = Color.white;
		transparent.a = 0.3f;
		//SetBulletType((ElementalType.Element)newType);
		for (int i = 0; i < HUD_Skills.Length; i++)
		{
			if (i == (int)newType)
			{
				HUD_Skills[i].GetComponent<Image>().color = Color.white;
			}
			else
				HUD_Skills[i].GetComponent<Image>().color = transparent;
		}
	}
}
