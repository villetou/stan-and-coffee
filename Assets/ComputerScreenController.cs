using UnityEngine;
using System.Collections;

public class ComputerScreenController : MonoBehaviour {

	private Vector3 originalScale;
	private bool screenOpened = false; 

	// Use this for initialization
	void Start () {
		this.originalScale = gameObject.transform.localScale;
		this.closeScreen ();
	}

	void Update()
	{
		if (Input.GetButtonDown ("Fire1")) {
			if (this.screenOpened) {
				this.closeScreen ();	
			} else {
				this.openScreen ();
			}
		}
	}

	void openScreen() {
		this.screenOpened = true;
		gameObject.transform.localScale = this.originalScale;
	}

	void closeScreen() {
		this.screenOpened = false;
		gameObject.transform.localScale = new Vector3(0, 0, 0);
	}
}
