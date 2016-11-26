using UnityEngine;
using System.Collections;


public class PositiveZCollision : MonoBehaviour {
	public GameObject earth;
	public bool collided = false;

	void OnTriggerEnter(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveZToTrue();
		this.collided = true;
	}

	void OnTriggerExit(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveZToFalse();
		this.collided = false;
	}

}