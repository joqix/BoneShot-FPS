using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals ("Player")) {
			ControlVida vida = gameObject.GetComponent<ControlVida> ();
			vida.reset ();
			Destroy (gameObject);
		}
	}
}
