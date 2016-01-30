using UnityEngine;
using System.Collections;

public class AdventureManager : MonoBehaviour
{
	public int MAX_CAFFEINE_LEVEL = 30;
	private int _caffeineLevel;
	private int _currentAdventure = -1;
	private float _adventureStartTime;
	private float _lastCoffeineDiminishTime;
	private float _nextSoundTime;
	private float _nextCoffeeSoundTime;
	public AdventureData[] Adventures;
	public GameObject CoffeeSoundNormal;
	public GameObject CoffeeSoundBad;
	public GameObject CoffeeSoundCritical;

	void Start()
	{
		_caffeineLevel = MAX_CAFFEINE_LEVEL;
		StartNextAdventure ();
	}

	void Update()
	{
		if (Time.realtimeSinceStartup > _nextSoundTime) {
			Adventures [_currentAdventure].PlayRandomAudio();
			QueueNextSound ();
		}
		if (Time.realtimeSinceStartup > _nextCoffeeSoundTime) {
			
			PlayAndQueueCoffeeSound ();
		}
		if (Time.realtimeSinceStartup > _lastCoffeineDiminishTime + 4) {
			_caffeineLevel--;
			_lastCoffeineDiminishTime = Time.realtimeSinceStartup;
		}

	}

	public void InteractWithCoffeeMaker()
	{
		_caffeineLevel = MAX_CAFFEINE_LEVEL;
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
		_nextSoundTime = Time.realtimeSinceStartup + Mathf.Floor(Random.value * 5f);
	}

	private void PlayAndQueueCoffeeSound()
	{
		GameObject soundConteiner;
		_nextCoffeeSoundTime = Time.realtimeSinceStartup + 4f + Mathf.Floor(Random.value * 7f);
		if (_caffeineLevel < 10) {
			soundConteiner = CoffeeSoundCritical;
		} else if (_caffeineLevel < 20) {
			soundConteiner = CoffeeSoundBad;

		} else {
			soundConteiner = CoffeeSoundNormal;
		}

		var audios = soundConteiner.GetComponents<AudioSource> ();
		audios[Random.Range(0,audios.Length)].Play();
	}
}

