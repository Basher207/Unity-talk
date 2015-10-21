using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour {

	void Update () {
		RaycastHit hit; 
		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit))
			transform.LookAt (hit.point);
		else
			transform.LookAt (Camera.main.ScreenPointToRay (Input.mousePosition).GetPoint (150));
	}
}