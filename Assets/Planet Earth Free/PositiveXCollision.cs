﻿using UnityEngine;
using System.Collections;


public class PositiveXCollision : MonoBehaviour {
	public GameObject earth;
	public bool collided = false;

	void OnTriggerEnter(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveXToTrue();
		this.collided = true;
	}

	void OnTriggerExit(Collider other){
		earth.GetComponent<EarthRotation> ().setPositiveXToFalse();
		this.collided = false;
	}

}