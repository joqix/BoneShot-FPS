using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVida : MonoBehaviour {
	public float vida = 100f;
	public Slider sliderVida;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//actualiza la barra de vida
		sliderVida.value = vida;
		comprueba ();
	}
	void OnCollisionEnter(Collision colision){
		
		if (colision.gameObject.tag == "esqueleto") {
			//si colisiona con un esqueleto
			if (vida > 0) {
				//pierde un punto de vida
				vida-=1;
			} 
		}
		
	}
	public void comprueba(){
		//si la vida es 0 el personaje muere
		if (vida <= 0) {
			Debug.Log ("Muere");
			Application.LoadLevel ("Menu");
		}
	}
	public void reset(){
		vida = 100f;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.Equals ("corazon")) {
			reset ();
			Destroy (other.gameObject);
		}
	}
}
