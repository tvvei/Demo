using UnityEngine;


public enum InputMode
{
	None,
	Keyboard,
	Mouse,
	Raycast,
	GUIKeyboard,
	GUIRocker,
	CanvasKeyboard,
	CanvasRocker,
}


public class PlayerManager : MonoBehaviour
{
	static private PlayerManager instance;

	static public PlayerManager Instance {
		get {
			return instance;
		}
	}

	public InputMode inputMode = InputMode.Keyboard;
	public GameObject[] controllers = new GameObject[0];
	private InputMode lastInputMode = InputMode.None;

	void Awake ()
	{
		instance = this;
	}

	void Start ()
	{

	}

	void Update ()
	{
		if (lastInputMode != inputMode) {
			for (int i = 0; i < controllers.Length; i++) {
				if (controllers [i] == null) {
					continue;
				}
				if (i == (int)inputMode - 1) {
					controllers [i].SetActive (true);
				} else {
					controllers [i].SetActive (false);
				}
			}
			lastInputMode = inputMode; 	
		}
	}
}