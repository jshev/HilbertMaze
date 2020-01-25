using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playControl1 : MonoBehaviour {
	public float speed = 10;
	private int count;
	public Text countText;
	//public Text winText;

	void Start() {
		count = 0;
		setCountText ();
		//winText.text = "";
	}

	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody> ().AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pickup")) {
			other.gameObject.SetActive (false);
			count += 1;
			setCountText ();
		}
	}

	void setCountText() {
		countText.text = "Count : " + count.ToString () + " / 1";
		if (count >= 1) {
			//winText.text = "You Win!!!";
			SceneManager.LoadScene("Scene2",  LoadSceneMode.Single);

		}
	}

}