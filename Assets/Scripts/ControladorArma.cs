using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/**
 * Controla un arma
 * */
public class ControladorArma : MonoBehaviour {
	public GameObject camara;
	public Slider barraMunicion;
	public int municion=50;
	public int cargadores = 2;
	void Start () {
	}
	void Update () {
		if (Input.GetButton ("Cancel")) {
			Application.LoadLevel ("Menu");
			//si se pulsa escape se vuelve a menu
		}
		if (Input.GetButtonDown("Fire1")&&municion>0) {
			//si hay municion dispara
			GetComponent<AudioSource> ().Play ();
			GetComponent<Animator> ().SetTrigger ("disparo");
			RaycastHit hit;
			Vector3 fwd = camara.transform.TransformDirection(Vector3.forward);
			//detecta si hay un objeto y la distancio, la distancia maxima es 100
			if (Physics.Raycast (camara.transform.position, fwd, out hit, 100f)) {
				Debug.DrawLine (transform.position, hit.point);
				GameObject objeto=hit.collider.gameObject;
				if(objeto.tag.Equals("esqueleto"))
				{
					//si ha disparado a un esqueleto lo destruye
					Destroy(objeto);
				}
				if (objeto.tag.Equals ("enemy")) {
					//si ha disparado a un alien le resta 1 de vida
					ControladorAlien alien= hit.collider.GetComponent<ControladorAlien>();
					alien.vida--;
				}
			}
			municion--;
			barraMunicion.value=municion;
		}
		if (Input.GetButtonDown ("recarga") && cargadores > 0) {
			Debug.Log ("recargado");
			municion = 50;
			barraMunicion.value=municion;
		}

		if (municion == 0 && cargadores > 1) {
			Debug.Log ("recarga");
		} else if (municion == 0) {
			Debug.Log ("Sin munición");
		}
	}
}
