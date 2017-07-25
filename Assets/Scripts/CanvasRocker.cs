using UnityEngine.EventSystems;
using UnityEngine;

public class CanvasRocker : MonoBehaviour
{
	public GameObject rocker;
	public RectTransform joystick;
	public float radius = 40f;
	private Vector2 center = Vector2.zero;

	void OnEnable ()
	{
		if (rocker != null) {
			rocker.SetActive (true);
		}
	}

	void OnDisable ()
	{
		if (rocker != null) {
			rocker.SetActive (false);
		}
	}

	void Start ()
	{
		EventTriggerListener.Get (joystick.gameObject).Drag = OnDrag;
		EventTriggerListener.Get (joystick.gameObject).EndDrag = OnEndDrag;
		center = joystick.position;
	}

	void OnDrag (PointerEventData eventData)
	{
		Vector2 distance = eventData.position - center;
		if (distance.magnitude >= radius) {
			joystick.position = distance.normalized * radius + center;
		} else {
			joystick.position = eventData.position;
		}
		PlayerController.Instance.AddForce (distance.normalized.x, distance.normalized.y);
	}

	void OnEndDrag (PointerEventData eventData)
	{
		joystick.position = center;
	}
}
