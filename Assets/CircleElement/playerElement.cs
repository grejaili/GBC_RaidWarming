using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerElement : MonoBehaviour 
{
    [SerializeField]
    bulletsType m_currentBulletType;

    //ElementalType.Element bulletType;

    public bulletsType currentBulletType
    {
        get {return m_currentBulletType; }
        set {this.m_currentBulletType = value; }
    }

    [SerializeField]
    GameObject[] elementsObj;

	// Use this for initialization
	void Start () 
    {
        this.changeElement(this.currentBulletType);
	}

    public void changeElement(bulletsType element)
    {
        foreach(GameObject elementObj in elementsObj)
        {
            elementObj.SetActive(false);
        }

        elementsObj[(int)currentBulletType].SetActive(true);
    }
}
