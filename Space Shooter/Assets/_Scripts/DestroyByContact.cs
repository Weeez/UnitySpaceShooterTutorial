using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameObject explosion = null;
	public GameObject playerExplosion  = null;

	void OnTriggerEnter(Collider other){

		//if(other.name != "Boundary"){
		if(other.tag == "Boundary"){
			return;        	
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if(other.tag == "Player"){
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);	
		}
        Destroy(other.gameObject);
		Destroy(gameObject);	
	}
}