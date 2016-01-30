using UnityEngine;
using System.Collections;

public class ComputerScreenController : MonoBehaviour {

	private Vector3 originalScale;
	private bool screenOpened = false; 
	public Animator anim;

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
		anim.SetBool("Open", true);
	}

	void closeScreen() {
		this.screenOpened = false;
		anim.SetBool("Open", false);
	}
}
