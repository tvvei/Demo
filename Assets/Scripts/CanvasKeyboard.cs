using UnityEngine;

public class CanvasKeyboard : MonoBehaviour
{
	public GameObject keyboard;
	public GameObject up;
	public GameObject down;
	public GameObject left;
	public GameObject right;
	private Vector2 axis = new Vector2 (0, 0);
	private bool isDown = false;

	void OnEnable ()
	{
		if (keyboard != null) {
			keyboard.SetActive (true);
		}
	}

	void OnDisable ()
	{
		if (keyboard != null) {
			keyboard.SetActive (false);
		}
	}

	void Start ()
	{
		EventTriggerListener.Get (up).onDown = OnPointerDown;
		EventTriggerListener.Get (down).onDown = OnPointerDown;
		EventTriggerListener.Get (left).onDown = OnPointerDown;
		EventTriggerListener.Get (right).onDown = OnPointerDown;
		EventTriggerListener.Get (up).onUp = OnPointerUp;
		EventTriggerListener.Get (down).onUp = OnPointerUp;
		EventTriggerListener.Get (left).onUp = OnPointerUp;
		EventTriggerListener.Get (right).onUp = OnPointerUp;
	}

	void Update ()
	{
		if (isDown) {
			PlayerController.Instance.AddForce (axis.x, axis.y);
		}
	}

	void OnPointerDown (GameObject go)
	{
		if (go == up) {
			axis = new Vector2 (0, 1);
		} else if (go == down) {
			axis = new Vector2 (0, -1);
		} else if (go == left) {
			axis = new Vector2 (-1, 0);
		} else if (go == right) {
			axis = new Vector2 (1, 0);
		}
		isDown = true;
	}

	void OnPointerUp (GameObject go)
	{
		isDown = false;
	}
}
