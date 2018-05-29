using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAlien : MonoBehaviour {
	public int vida=10;
	public float velocidad=5f;
	public Transform personaje;
	public ControlVida vidas;
	bool hadisparado=false;
	public GameObject muere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mirar();
		if (Vector3.Distance (GetComponent<Transform> ().position, personaje.position) > 10.0f) {
			mirar();
			GetComponent<Animator> ().SetBool ("caminar", true);
			//avanza
			GetComponent<Transform> ().position += GetComponent<Transform> ().forward * velocidad * Time.deltaTime;
		} else {
			//dispara
			GetComponent<Animator> ().SetBool ("caminar", false);
			GetComponent<Animator> ().SetTrigger ("disparar");
			disparar ();
		}
		if (vida <= 0) {
			//muere
			Instantiate (muere, transform.position+new Vector3(0,1,0), Quaternion.identity);
			Destroy (gameObject);
		}
	}
	void disparar(){
		
			RaycastHit hit;
			Vector3 fwd = GetComponent<Transform> ().TransformDirection (Vector3.forward);
			//detecta si hay un objeto y la distancioa, la distancia maxima es 100
		if (Physics.Raycast (GetComponent<Transform> ().position, fwd, out hit, 100f)) {
			GetComponent<AudioSource> ().Play ();
			//pinta una linea para depurar (no se ve en el juego)
			Debug.DrawLine (transform.position, hit.point);

			GameObject objeto = hit.collider.gameObject;
			if (objeto.tag.Equals ("Player")) {
				//si ha dado al personaje le quita vida
				vidas.vida = vidas.vida - 0.05f;
			}
				
		} 
			
	}
	void mirar(){
		//mira al personaje
		GetComponent<Transform> ().LookAt (personaje);
	}

}
