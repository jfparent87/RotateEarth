using UnityEngine;
using System.Collections;
using Vuforia;

public class VirtualButtonLeft : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject virtualButtonNegativeY;
	public bool buttonDown = false;
	public GameObject earth;

	void Start () {
		virtualButtonNegativeY = GameObject.Find ("NegativeYButton");
		virtualButtonNegativeY.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Down");
		earth.GetComponent<EarthRotation> ().setNegativeZToTrue();
		buttonDown = true;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Up");
		earth.GetComponent<EarthRotation> ().setNegativeZToFalse();
		buttonDown = false;
	}

}
