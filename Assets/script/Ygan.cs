using UnityEngine;

public class Ygan : MonoBehaviour
{
	public player player;
	public GUISkin guiSkin;
	public Vector2 center = Vector2.zero;
	public float radius = 50;
	public Texture background;

	private Vector2 pos = new Vector2 (Screen.width - 200, Screen.height - 200);
	private Vector2 size = new Vector2 (100, 100);
	private Vector2 offset = Vector2.zero;
	private Vector2 backgroundSize = new Vector2 (200, 200); 
	private bool isDown;
	private Rigidbody rd;



	void Start ()
	{
		
		rd = GetComponent<Rigidbody> ();
		center = pos + 0.5f * size;
	}

	void OnGUI ()
	{
		GUI.Box (new Rect (center - 0.5f * backgroundSize, backgroundSize), "", guiSkin.box);

		if (GUI.RepeatButton (new Rect (pos, size), "", guiSkin.button) && !isDown) {
			Vector2 mousePos = new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y);
			offset = pos - mousePos;
			isDown = true;
			Debug.Log ("sssss");
		}

		if (isDown) {
			pos = new Vector2 (Input.mousePosition.x, Screen.height - Input.mousePosition.y) + offset;

			if (Vector2.Distance (center, pos + 0.5f * size) > radius) {
				pos = center - 0.5f * size + (pos - center).normalized * radius;
			}

			var v2 = pos + 0.5f * size - center;
			var direction = v2.normalized;
			var k = v2.magnitude / radius;

			rd.AddForce (new Vector3 (direction.x ,0, -direction.y) * k * player.force);
			Debug.Log (k * player.force);
		}

		if (Input.GetMouseButtonUp (0) && isDown) {
			Debug.Log ("zzzzz");
			pos = center - 0.5f * size;
			isDown = false;
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
