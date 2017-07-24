using UnityEngine.EventSystems;
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
		EventTriggerListener.Get (up).PointerDown = OnPointerDown;
		EventTriggerListener.Get (down).PointerDown = OnPointerDown;
		EventTriggerListener.Get (left).PointerDown = OnPointerDown;
		EventTriggerListener.Get (right).PointerDown = OnPointerDown;
		EventTriggerListener.Get (up).PointerUp = OnPointerUp;
		EventTriggerListener.Get (down).PointerUp = OnPointerUp;
		EventTriggerListener.Get (left).PointerUp = OnPointerUp;
		EventTriggerListener.Get (right).PointerUp = OnPointerUp;
	}

	void Update ()
	{
		if (isDown) {
			PlayerController.Instance.AddForce (axis.x, axis.y);
		}
	}

	void OnPointerDown (PointerEventData eventData)
	{
		if (eventData.selectedObject == up) {
			axis = new Vector2 (0, 1);
		} else if (eventData.selectedObject == down) {
			axis = new Vector2 (0, -1);
		} else if (eventData.selectedObject == left) {
			axis = new Vector2 (-1, 0);
		} else if (eventData.selectedObject == right) {
			axis = new Vector2 (1, 0);
		}
		isDown = true;
	}

	void OnPointerUp (PointerEventData eventData)
	{
		PlayerController.Instance.AddForce (0, 0);
		isDown = false;
	}
}
