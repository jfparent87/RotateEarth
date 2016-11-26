using UnityEngine;
using System.Collections;
using Vuforia;

public class VirtualButtonRight : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject virtualButtonPositiveY;
	public bool buttonDown = false;
	public GameObject earth;

	void Start () {
		virtualButtonPositiveY = GameObject.Find ("PositiveYButton");
		virtualButtonPositiveY.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Down");
		earth.GetComponent<EarthRotation> ().setPositiveZToTrue();
		buttonDown = true;
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour virtualButton){
		Debug.Log("Button Up");
		earth.GetComponent<EarthRotation> ().setPositiveZToFalse();
		buttonDown = false;
	}

}
