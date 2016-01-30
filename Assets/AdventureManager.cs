using UnityEngine;
using System.Collections;

public class AdventureManager : MonoBehaviour
{
	private int _currentAdventure = -1;
	private float _adventureStartTime;
	private float _lastCoffeineDiminishTime;
	private float _nextSoundTime;
	public AdventureData[] Adventures;

	void Start()
	{
		StartNextAdventure ();
	}

	void Update()
	{
		if (Time.realtimeSinceStartup > _nextSoundTime) {
			Adventures [_currentAdventure].PlayRandomAudio();
			QueueNextSound ();
		}
	}

	public void StartNextAdventure()
	{
		_currentAdventure++;
		_adventureStartTime = Time.realtimeSinceStartup;
		QueueNextSound ();
		_lastCoffeineDiminishTime = Time.realtimeSinceStartup;
	}

	private void QueueNextSound()
	{
		_nextSoundTime = Time.realtimeSinceStartup + Mathf.Floor(Random.value * 7f);
	}

}

