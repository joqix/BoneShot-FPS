using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Controla las acciones del personaje
 * */
public class ControladorPersonaje : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	/**
	 * Al hacer click en el boton izquierdo pega un puñetazo
	 * */
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GetComponent<Animator> ().SetTrigger("Punyo");
		}
	}
}
