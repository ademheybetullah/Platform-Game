using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
	public Button[] levels;
	public Text[] starts;


	void Start()
	{
		for (int i = 0; i < levels.Length; i++)
		{
			string levelName = levels[i].name;
			if (PlayerPrefs.GetInt(levelName) == 1)
				levels[i].interactable = true;
			else
				levels[i].interactable = false;
		}
		levels[0].interactable = true;
		for (int i = 0; i < starts.Length; i++)
		{
			string starName = starts[i].name;
			starts[i].text = "x" + PlayerPrefs.GetInt(starName);
		}
	}
}
