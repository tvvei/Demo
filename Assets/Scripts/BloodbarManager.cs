using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BloodbarManager : MonoBehaviour
{
	public GameObject bloodbarPrefab;
	public RectTransform canvasRectTransform;
	private Dictionary<Bloodbar, Scrollbar> bloodbars = new Dictionary<Bloodbar, Scrollbar> ();

	static private BloodbarManager instance;

	static public BloodbarManager Instance {
		get {
			return instance;
		}
	}

	void Awake ()
	{
		instance = this;
	}

	void Start ()
	{
		
	}

	void Update ()
	{
		foreach (KeyValuePair<Bloodbar, Scrollbar> bar in bloodbars) {
			bar.Value.transform.position = bar.Key.transform.position + Vector3.up;
			bar.Value.transform.LookAt (Camera.main.transform);
			bar.Value.size = bar.Key.health.hp / bar.Key.health.maxHp;
		}
	}

	public void AddBloodbar (Bloodbar bar)
	{
		if (bloodbarPrefab == null) {
			return;
		}
		if (!bloodbars.ContainsKey (bar)) {
			GameObject go = Instantiate<GameObject> (bloodbarPrefab);
			go.transform.SetParent (canvasRectTransform, false);
			go.transform.position = bar.transform.position;
			go.transform.rotation = bar.transform.rotation;
			bloodbars.Add (bar, go.GetComponent<Scrollbar> ());
		}
	}
}
