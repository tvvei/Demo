using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
	public GameObject image;

	Dropdown dropdownItem;
	List<string> tempNames;

	void Awake ()
	{
		dropdownItem = GetComponent<Dropdown> ();
		tempNames = new List<string> ();
	}

	void Start ()
	{
		AddNames ();
		UpdateDropdownView (tempNames);
	}


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
		
	private void AddNames ()
	{
		string s1 = "Keyboard";
		string s2 = "Mouse";
		string s3 = "Raycast";
		string s4 = "GUIKeyboard";
		string s5 = "GUIRocker";
		string s6 = "CanvasKeyboard";
		string s7 = "CanvasRocker";

		tempNames.Add (s1);
		tempNames.Add (s2);
		tempNames.Add (s3);
		tempNames.Add (s4);
		tempNames.Add (s5);
		tempNames.Add (s6);
		tempNames.Add (s7);

	}

	void OnUpdate(){
	
	}

//	public void OnValueChanged (int index)
//	{
//		
//				
//		if (index == 0) {
//			player.inputmode = player.InputMode.keyboard;
//		}else if(index == 1){
//			player.inputmode = player.InputMode.mouse;
//		}else if(index == 2){
//			player.inputmode = player.InputMode.ray;
//		}else if(index == 3){
//			player.inputmode = player.InputMode.button1;
//		}else if(index == 4){
//			player.inputmode = player.InputMode.rocker1;
//		}else if(index == 5){
//			player.inputmode = player.InputMode.button;
//		}else if(index == 6){
//			player.inputmode = player.InputMode.rocker;
//		}

}
