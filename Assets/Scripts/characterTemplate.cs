using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterTemplate : MonoBehaviour 
{

    [SerializeField]
    [Range(1,10)]
    protected int maxLife = 1;

    [SerializeField]
    [Range(1,10)]
    int m_currentLife;

	// Movement parameters
	public float moveSpeed;
	public float turnSpeed;
	protected Rigidbody rb;

    public int currentLife
    {
        get {return m_currentLife; }
        set 
        {
            this.m_currentLife = value;

            if (this.m_currentLife < 0)
            {
                this.m_currentLife = 0;
            }

            if (this.m_currentLife > maxLife)
            {
                this.m_currentLife = maxLife;
            }
        }
    }

    [SerializeField]
    protected GameObject Wave;

    protected bool isAlive()
    {
        if (this.maxLife <= 0)
        {
            return false;
        }

        return true;
    }

    protected void Explode()
    {
        if (Wave)
        {
            GameObject newWave = Instantiate(Wave, 
                                     transform.position + Vector3.up * (transform.localScale.y / 2),
                                     Quaternion.identity);
            if (newWave)
            {
                Destroy(gameObject);
            }
        }
    }

	

	void Awake()
    {
        this.currentLife = this.maxLife;
    }
}
