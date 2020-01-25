using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinningCube : MonoBehaviour {

	private int spinny = 60;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.back, spinny * Time.deltaTime);
	}
}
