using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public Transform target;
	public GameObject targetDrone;
	public GameObject startingDrone;
	public float speed;
	public bool detected = false;
	Animator animator; 
	private bool alreadyDone = false;

	void Start(){
		animator = GetComponent<Animator>();
	}

	void Update() {
		float step = speed * Time. deltaTime;
		if (target.GetComponent<Vuforia.DefaultTrackableEventHandler> ().tracking && !alreadyDone) {
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
			detected = true;
			animator.SetBool("targetDetected", true);
			//targetDrone.transform.localScale += new Vector3 (0.7F, 0.7F, 0.7F);
			//StartCoroutine(waitDroneMovement());
			//Destroy (startingDrone);
			//alreadyDone = true;

		} else {
			detected = false;
			animator.SetBool("targetDetected", false);
		}
	}

	IEnumerator waitDroneMovement() {
		yield return new WaitForSeconds(100);
	}
}