using UnityEngine;
using System.Collections;

public class AdventureManager : MonoBehaviour
{
	private int _currentAdventure = 0;
	private float _adventureStartTime;
	private float _nextSoundTime;
	public AdventureData[] Adventures;

	void Update()
	{
		if (Time.realtimeSinceStartup > _nextSoundTime) {
			Adventures [_currentAdventure].PlayRandomAudio();
			QueueNextSound ();
		}
	}

	public void StartNextAdventure()
	{
		_adventureStartTime = Time.realtimeSinceStartup;
		QueueNextSound ();
	}

	private void QueueNextSound()
	{
		_nextSoundTime = Time.realtimeSinceStartup + Mathf.Floor(Random.value * 7f);
	}

}

