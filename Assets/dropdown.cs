using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
	public play play; 
	public GameObject image;
	public GameObject panel;

	Dropdown dropdownItem;
	List<string> tempNames;

	void Awake ()
	{
		dropdownItem = GetComponent<Dropdown> ();
		tempNames = new List<string> ();
	}

	void Start ()
	{
		image.SetActive (false);
		panel.SetActive (false);
		AddNames ();
		UpdateDropdownView (tempNames);
	}


	/// <summary>
	/// 刷数据
	/// </summary>
	/// <param name="showNames"></param>
	private void UpdateDropdownView (List<string> showNames)
	{
		dropdownItem.options.Clear ();
		Dropdown.OptionData tempData;
		for (int i = 0; i < showNames.Count; i++) {
			tempData = new Dropdown.OptionData ();
			tempData.text = showNames [i];
			dropdownItem.options.Add (tempData);
		}
		dropdownItem.captionText.text = showNames [0];
	}

	/// <summary>
	/// 模拟数据
	/// </summary>
	private void AddNames ()
	{
		string s1 = "keyboard";
		string s2 = "mouse";
		string s3 = "ray";
		string s4 = "button1";
		string s5 = "rocker1";
		string s6 = "rocker";
		string s7 = "button";

		tempNames.Add (s1);
		tempNames.Add (s2);
		tempNames.Add (s3);
		tempNames.Add (s4);
		tempNames.Add (s5);
		tempNames.Add (s6);
		tempNames.Add (s7);

	}
		
	public void OnValueChanged (int index)
	{
				
		if (index == 0) {
			play.inputmode = play.InputMode.keyboard;
		}else if(index == 1){
			play.inputmode = play.InputMode.mouse;
		}else if(index == 2){
			play.inputmode = play.InputMode.ray;
		}else if(index == 3){
			play.inputmode = play.InputMode.button1;
		}else if(index == 4){
			play.inputmode = play.InputMode.rocker1;
		}else if(index == 5){
			play.inputmode = play.InputMode.rocker;
		}else if(index == 6){
			play.inputmode = play.InputMode.button;
		}
	}
}
