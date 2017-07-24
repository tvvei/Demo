using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using System;

public class SelectInputMode : MonoBehaviour
{
	Dropdown dropdown;

	void Start ()
	{
		dropdown = GetComponent<Dropdown> ();
		string[] names = Enum.GetNames (typeof(InputMode));
		dropdown.options.Clear ();
		Dropdown.OptionData tempData;
		for (int i = 0; i < names.Length; i++) {
			tempData = new Dropdown.OptionData ();
			tempData.text = names [i];
			dropdown.options.Add (tempData);
		}
		dropdown.captionText.text = names [0];

		dropdown.onValueChanged.AddListener ((modeIndex) => {
			PlayerManager.Instance.inputMode = (InputMode)modeIndex;
		});
	}
}
