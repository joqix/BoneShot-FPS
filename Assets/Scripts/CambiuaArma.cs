using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiuaArma : MonoBehaviour {
	public GameObject arma1, arma2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("arma1")) {
			arma1.SetActive (true);
			arma2.SetActive (false);
		}
		if (Input.GetButtonDown ("arma2")) {
			arma1.SetActive (false);
			arma2.SetActive (true);
		}
	}
}
