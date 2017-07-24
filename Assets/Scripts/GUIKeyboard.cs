using UnityEngine;

public class GUIKeyboard : MonoBehaviour
{
	public Texture upTexture;
	public Texture downTexture;
	public Texture leftTexture;
	public Texture rightTexture;

	void Start ()
	{
		
	}

	void OnGUI ()
	{
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 120, 50, 50), upTexture)) {
			PlayerController.Instance.AddForce (0,6);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 60, 50, 50), downTexture)) {
			PlayerController.Instance.AddForce (0,-6);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 180, Screen.height - 60, 50, 50), leftTexture)) {
			PlayerController.Instance.AddForce (-6,0);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 60, Screen.height - 60, 50, 50), rightTexture)) {
			PlayerController.Instance.AddForce (6,0);
		}
	}
}
