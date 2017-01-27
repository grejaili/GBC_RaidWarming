using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMaterial : MonoBehaviour {

    [SerializeField]
    float amountDissolve = 0.316f;

    [SerializeField]
    [Range(0f,1f)]
    float speedDissolve = 0.01f;

    [SerializeField]
    Material objectMaterial;

    int direction = 1;

    float minDissolve = 0.316f;
    float maxDissolve = 0.7f;
	
	// Update is called once per frame
	void Update () {

        Renderer rend = GetComponent<Renderer>();

        rend.material.SetFloat("_DissolveAmount", amountDissolve);

        amountDissolve -= direction * this.speedDissolve;

        if (amountDissolve <= minDissolve)
        {
            direction = -1;
        }
            else if (amountDissolve >= maxDissolve)
        {
            direction = 1;
        }
		
	}
}
