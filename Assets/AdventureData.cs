using UnityEngine;
using System.Collections;

public class AdventureData : MonoBehaviour
{
	public GameObject RandomAudios;
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

