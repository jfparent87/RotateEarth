using UnityEngine;
using System.Collections;


public class PositiveYCollision : MonoBehaviour {
	public GameObject earth;
	public bool collided = false;

	void OnTriggerEnter(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveYToTrue();
		this.collided = true;
	}

	void OnTriggerExit(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveYToFalse();
		this.collided = false;
	}

}