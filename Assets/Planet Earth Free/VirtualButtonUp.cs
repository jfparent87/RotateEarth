using UnityEngine;
using System.Collections;
using Vuforia;

public class VirtualButtonUp : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject virtualButtonPositiveZ;
	public bool buttonDown = false;
	public GameObject earth;

	void Start () {
		virtualButtonPositiveZ = GameObject.Find ("PositiveZButton");
		virtualButtonPositiveZ.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour virtualButton){
		earth.GetComponent<EarthRotation> ().setPositiveXToTrue();
		buttonDown = true;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour virtualButton){
		earth.GetComponent<EarthRotation> ().setPositiveXToFalse();
		buttonDown = false;
	}

}
