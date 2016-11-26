using UnityEngine;
using System.Collections;

public class EarthRotation : MonoBehaviour {
	[Tooltip("Spin: Yes or No")]
	public bool spinPositiveX;
	public bool spinNegativeX;
	public bool spinPositiveY;
	public bool spinNegativeY;
	public bool spinPositiveZ;
	public bool spinNegativeZ;
	[Tooltip("Spin the parent object instead of the object this script is attached to")]
	public bool spinParent;
	public float speed = 14f;

	public float direction = 1f;
	public float directionChangeSpeed = 2f;

	void Update() {

		// Rotations direction
		if (direction < 1f) {
			direction += Time.deltaTime / (directionChangeSpeed / 2);
		}

		if (spinPositiveX) {
			if (spinParent)
				transform.parent.transform.Rotate(Vector3.right, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(Vector3.right, (speed * direction) * Time.deltaTime, Space.World);
		}

		if (spinNegativeX) {
			if (spinParent)
				transform.parent.transform.Rotate(-Vector3.right, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(-Vector3.right, (speed * direction) * Time.deltaTime, Space.World);
		}

		if (spinPositiveY) {
			if (spinParent)
				transform.parent.transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime, Space.World);
		}

		if (spinNegativeY) {
			if (spinParent)
				transform.parent.transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime, Space.World);
		}

		if (spinPositiveZ) {
			if (spinParent)
				transform.parent.transform.Rotate(Vector3.back, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(Vector3.back, (speed * direction) * Time.deltaTime, Space.World);
		}

		if (spinNegativeZ) {
			if (spinParent)
				transform.parent.transform.Rotate(-Vector3.back, (speed * direction) * Time.deltaTime, Space.World);
			else
				transform.Rotate(-Vector3.back, (speed * direction) * Time.deltaTime, Space.World);
		}
	}

	public void setPositiveXToTrue(){
		this.spinPositiveX = true;
	}
	public void setNegativeXToTrue(){
		this.spinNegativeX = true;
	}
	public void setPositiveYToTrue(){
		this.spinPositiveY = true;
	}
	public void setNegativeYToTrue(){
		this.spinNegativeY = true;
	}
	public void setPositiveZToTrue(){
		this.spinPositiveZ = true;
	}
	public void setNegativeZToTrue(){
		this.spinNegativeZ = true;
	}
	public void setPositiveXToFalse(){
		this.spinPositiveX = false;
	}
	public void setNegativeXToFalse(){
		this.spinNegativeX = false;
	}
	public void setPositiveYToFalse(){
		this.spinPositiveY = false;
	}
	public void setNegativeYToFalse(){
		this.spinNegativeY = false;
	}
	public void setPositiveZToFalse(){
		this.spinPositiveZ = false;
	}
	public void setNegativeZToFalse(){
		this.spinNegativeZ = false;
	}
}