using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// Mitch Version

public class UI_Manager : MonoBehaviour {

	public uint specialThreshold;
	private int comboCounter = 0;
	private bool paused;
	public bool initializedScene = false;

	private Animator anim;
	private Player player;
	private GameObject HUD_ComboCounter;
	private GameObject[] HUD_Skills;

	public static UI_Manager _instance = null;
	public static UI_Manager instance
	{
		get { return _instance; }
		set { _instance = value; }
	}

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find("Player").GetComponent<Player>();
		HUD_Skills = new GameObject[4];

		if (instance)
		{
			DestroyImmediate(gameObject);
		}
		else
		{
			instance = this;

			DontDestroyOnLoad(this);
		}

		// Initialize Hud parts
		for (int i = 0; i < HUD_Skills.Length; i++)
		{
			HUD_Skills[i] = GameObject.Find("HUD_" + ((ElementalType.Element)i).ToString());
			HUD_Skills[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.3f);
			//Debug.Log("Set HUD_SKILL");
			//HUD_Skills[i].GetComponentInChildren<Text>().text = ((ElementalType.Element)i).ToString();
			//Debug.Log(((ElementalType.Element)i).ToString());
		}

		SetBulletType(ElementalType.Element.Fire);

		//player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		//HUD_ComboCounter = GameObject.Find("HUD_Combo");
		//HUD_ComboCounter.GetComponent<Text>().text = "";
		//for (int i = 0; i < HUD_Skills.Length; i++)
		//{
		//	HUD_Skills[i] = GameObject.Find("HUD_" + ((ElementalType.Element)i).ToString());
		//	HUD_Skills[i].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.3f);
		//	//HUD_Skills[i].GetComponentInChildren<Text>().text = ((ElementalType.Element)i).ToString();
		//	//Debug.Log(((ElementalType.Element)i).ToString());
		//}

		//if(specialThreshold == 0)
		//{
		//	//Debug.Log("specialThreshold not set in inspector, defaulting to 6");
		//	specialThreshold = 6;
		//}
		//     // comboPointsText = GameObject.FindGameObjectWithTag("ComboPointText");  
	}

	void Update()
	{
		if(!initializedScene && SceneManager.GetActiveScene().buildIndex == 1)
		{
			if (!player)
				player = GameObject.Find("Player").GetComponent<Player>();
			
			HUD_ComboCounter = GameObject.Find("HUD_Combo");
			HUD_ComboCounter.GetComponent<Text>().text = "";
			
			if (specialThreshold == 0)
			{
				//Debug.Log("specialThreshold not set in inspector, defaulting to 6");
				specialThreshold = 6;
			}
			GameManager.instance.OnSceneTransition();
			initializedScene = true;
		}
	
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
		    //string comboStatus = " Hit Combo!";
			instance.comboCounter += 1;
			instance.HUD_ComboCounter.GetComponent<Text>().text = instance.comboCounter.ToString();
		}
		if (instance.comboCounter % instance.specialThreshold == 0)
		{
			//Debug.Log("Some kinda special shit should happen.");
		}
    }

	public static void ResetComboPoints()
	{
		if (instance)
		{
			instance.HUD_ComboCounter.GetComponent<Text>().text = "";
			instance.comboCounter = 0;
		}
		
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
		//Debug.Log("Player's current bullet type: " + player.currentBulletType.ToString());

		Color transparent = Color.white;
		transparent.a = 0.2f;

		for (int i = 0; i < HUD_Skills.Length; i++)
		{
			if (i == (int)newType && HUD_Skills[i].GetComponentInChildren<Image>())
			{
				HUD_Skills[i].GetComponentInChildren<Image>().color = Color.white;
				anim = HUD_Skills[i].GetComponentInChildren<Animator>();
				anim.SetBool("showEffect", true);
			}
			else
			{
				HUD_Skills[i].GetComponent<Image>().color = transparent;
				anim = HUD_Skills[i].GetComponentInChildren<Animator>();
				anim.SetBool("showEffect", false);
				anim.CrossFade("hideEffect", 0f);
			}
		}
	}


	public int GetBulletType()
	{
		string temp = player.currentBulletType.ToString();
		switch(temp)
		{
			case "Fire":
				temp = "0";
				break;
			case "Earth":
				temp = "1";
				break;
			case "Air":
				temp = "2";
				break;
			case "Water":
				temp = "3";
				break;
			default:
				temp = "0";
				break;
		}
		return int.Parse(temp);
	}

	public void StartGame()
	{
		Debug.Log("We are in the beam!");
		
		SceneManager.LoadScene(1);
	}

	public void QuitGame()
	{
		Debug.Log("I AM QUITTING THE BEAM");
		Application.Quit();
	}
}
