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
	public GameObject rocker;
	public InputMode inputMode = InputMode.Keyboard;
	public GameObject[] controllers = new GameObject[0];
	private InputMode lastInputMode = InputMode.None;

	void Start ()
	{

	}

	void Update ()
	{
		if (inputMode != InputMode.CanvasRocker) {
			rocker.SetActive (false);
		} else {
			rocker.SetActive (true);
		}

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

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "prefab") {
			MeshRenderer mr = collider.gameObject.GetComponent<MeshRenderer> ();
			mr.material.color = new Color (Random.Range (0, 1f), Random.Range (0, 1f), Random.Range (0, 1f), 0.5f);
			Destroy (collider.gameObject, 3);
		}
	}
}