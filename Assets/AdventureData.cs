﻿using UnityEngine;
using System.Collections;

public class AdventureData : MonoBehaviour
{
	public GameObject TargetItem;
	public GameObject RandomAudios;
	public AudioSource SuccessAudio;
	public AudioSource RepeatingLevelAudio;
	// Use this for initialization
	void Start ()
	{
	
	}
	 
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void PlayRandomAudio()
	{
		var audios = RandomAudios.GetComponents<AudioSource> ();
		audios[Random.Range(0,audios.Length)].Play();
	}
}

