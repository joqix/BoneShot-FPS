using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambiarEscena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Cancel")) {
			Application.Quit ();
		}
		if (Input.GetKey("c")) {
			Application.LoadLevel ("ciudad");
		}
		if (Input.GetKey("b")) {
			Application.LoadLevel ("bosque");
		}
		
	}
	//NO DETECTA LA COLISION
	void OnCollisionEnter(Collision collision){
		print ("sa chocao");
		if (collision.gameObject.tag.Equals ("Player")) {
			Application.LoadLevel ("ciudad");
		}
	}
}
