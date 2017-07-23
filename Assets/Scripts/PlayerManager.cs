using UnityEngine;

public enum InputMode
{
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
	public InputMode inputMode = InputMode.Keyboard;
	public GameObject[] controllers = new GameObject[0];
	private InputMode lastInputMode = InputMode.Keyboard;

	void Start ()
	{
		lastInputMode = inputMode;
	}

	void Update ()
	{
		if (lastInputMode != inputMode) {
			for (int i = 0; i < controllers.Length; i++) {
				if (controllers [i] == null) {
					continue;
				}
				if (i == (int)inputMode) {
					controllers [i].SetActive (true);
				} else {
					controllers [i].SetActive (false);
				}
			}
			lastInputMode = inputMode; 	
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
			Destroy (collider.gameObject, 3);
		}
	}
}