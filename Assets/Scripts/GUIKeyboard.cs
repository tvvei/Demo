using UnityEngine;

public class GUIKeyboard : MonoBehaviour
{
	public Texture upTexture;
	public Texture downTexture;
	public Texture leftTexture;
	public Texture rightTexture;
	public Rigidbody rigid;
	public int force = 5;

	void Start ()
	{
		
	}

	void OnGUI ()
	{
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 120, 50, 50), upTexture)) {
			rigid.AddForce (new Vector3 (0, 0, 10) * force);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 120, Screen.height - 60, 50, 50), downTexture)) {
			rigid.AddForce (new Vector3 (0, 0, -10) * force);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 180, Screen.height - 60, 50, 50), leftTexture)) {
			rigid.AddForce (new Vector3 (-10, 0, 0) * force);
		}
		if (GUI.RepeatButton (new Rect (Screen.width - 60, Screen.height - 60, 50, 50), rightTexture)) {
			rigid.AddForce (new Vector3 (10, 0, 0) * force);
		}
	}
}
