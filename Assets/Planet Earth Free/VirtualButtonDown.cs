using UnityEngine;
using System.Collections;
using Vuforia;

public class VirtualButtonDown : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject virtualButtonNegativeZ;
	public bool buttonDown = false;
	public GameObject earth;

	void Start () {
		virtualButtonNegativeZ = GameObject.Find ("NegativeZButton");
		virtualButtonNegativeZ.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Down");
		earth.GetComponent<EarthRotation> ().setNegativeXToTrue();
		buttonDown = true;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Up");
		earth.GetComponent<EarthRotation> ().setNegativeXToFalse();
		buttonDown = false;
	}

}
