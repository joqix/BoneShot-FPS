using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Controla las acciones de un esqueleto
 * */
public class ControladorSkeleton : MonoBehaviour {
	public Transform personaje;
	public float velocidad=5f;
	public GameObject muere;
	void Start () {
		
	}

	/**
	 * Por cada actualizacion se coloca mirando hacia el personaje si esta a mas de 2 de distancia avanza y si no ataca
	 * */
	void Update () {
		//Esto hace que mire al personaje
		GetComponent<Transform> ().LookAt (personaje);
		//comprueva la distancia con el personaje
		if (Vector3.Distance (GetComponent<Transform> ().position, personaje.position) > 2.0f) {
			//avanza
			GetComponent<Transform>().position+=GetComponent<Transform>().forward*velocidad*Time.deltaTime;
		} else {
			//ataca
			GetComponent<Animator> ().SetTrigger ("atacar");
		}
	}
	void OnDestroy(){
		Instantiate (muere, transform.position+new Vector3(0,1,0), Quaternion.identity);
	}

}
