using UnityEngine;
using System.Collections;


public class NegativeZCollision : MonoBehaviour {
	public GameObject earth;
	public bool collided = false;

	void OnTriggerEnter(Collider other){
		earth.GetComponent<EarthRotation> ().setNegativeZToTrue();
		this.collided = true;
	}

	void OnTriggerExit(Collider other){
		earth.GetComponent<EarthRotation> ().setNegativeZToFalse();
		this.collided = false;
	}
}