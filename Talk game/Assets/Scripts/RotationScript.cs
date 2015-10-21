using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	public KeyCode right;
	public KeyCode left;
	public float degreesPerSecond;

	void Update () {
		if (Input.GetKey (right)) {
			float angle = degreesPerSecond * Time.deltaTime;
			transform.Rotate (new Vector3 (0, angle));
		} else if (Input.GetKey (left)) {
			float angle = degreesPerSecond * Time.deltaTime;
			transform.Rotate (new Vector3 (0,-angle));
		}
	}
}
