using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	
	public KeyCode button;
	public GameObject bullets;
	public float bulletSpeed;

	void Update () {
		if (Input.GetKeyDown (button)) {
			GameObject bullet = Instantiate (bullets, transform.position, Quaternion.identity) as GameObject;
			bullet.GetComponent<Rigidbody> ().velocity  = transform.forward * bulletSpeed;
		}
	}
}