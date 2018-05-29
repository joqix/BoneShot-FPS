using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {
	public GameObject[]enemigos;
	public int tiempoMin = 5, tiempoMax = 100;
	// Use this for initialization
	void Start () {
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Generar(){
		
		Instantiate (enemigos[Random.Range (0, enemigos.Length)], transform.position, Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
	}
}
