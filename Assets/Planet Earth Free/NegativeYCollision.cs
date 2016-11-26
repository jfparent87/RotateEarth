using UnityEngine;
using System.Collections;


public class NegativeYCollision : MonoBehaviour {
	public GameObject earth;
	public bool collided = false;

	void OnTriggerEnter(Collider other){
		earth.GetComponent<EarthRotation> ().setNegativeYToTrue();
		this.collided = true;
	}

	void OnTriggerExit(Collider other){
		earth.GetComponent<EarthRotation> ().setNegativeYToFalse();
		this.collided = false;
	}
}