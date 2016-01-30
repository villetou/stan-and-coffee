﻿using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	public DoorView[] Doors;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			foreach (var door in Doors) {
				if(door.GetComponent<BoxCollider2D>().IsTouching(gameObject.GetComponent<BoxCollider2D>()))
				{
					if (door.upDoor != null) {
						transform.position = door.upDoor.transform.position;
					}
				}

			}
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			foreach (var door in Doors) {
				if(door.GetComponent<BoxCollider2D>().IsTouching(gameObject.GetComponent<BoxCollider2D>()))
				{
					if (door.downDoor != null) {
						transform.position = door.downDoor.transform.position;
					}
				}

			}
		}
	}
}