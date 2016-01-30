using UnityEngine;
using System.Collections;

public class AdventureManager : MonoBehaviour
{
	private int _currentAdventure;
	private float _adventureStartTime;
	public AdventureData[] Adventures;

	public void StartNextAdventure()
	{
		_adventureStartTime = Time.realtimeSinceStartup;
	}

}

