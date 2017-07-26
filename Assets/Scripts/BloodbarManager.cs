using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BloodbarManager : MonoBehaviour
{
	public GameObject bloodbarPrefab;
	public RectTransform canvasRectTransform;
	private Dictionary<Health, Scrollbar> bloodbars = new Dictionary<Health, Scrollbar> ();

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
		foreach (KeyValuePair<Health, Scrollbar> health in bloodbars) {
			health.Value.transform.position = health.Key.transform.position + Vector3.up;
			health.Value.transform.LookAt (Camera.main.transform);
		}
	}

	public void AddBloodbar (Bloodbar bar)
	{
		if (bloodbarPrefab == null) {
			return;
		}
		Health health = bar.GetComponent<Health> ();
		health.OnDamageEvent += OnDamage;
		if (!bloodbars.ContainsKey (health)) {
			GameObject go = Instantiate<GameObject> (bloodbarPrefab);
			go.transform.SetParent (canvasRectTransform, false);
			go.transform.position = bar.transform.position;
			go.transform.rotation = bar.transform.rotation;
			bloodbars.Add (health, go.GetComponent<Scrollbar> ());
		}
	}

	public void OnDamage (Health health)
	{
		if (bloodbars.ContainsKey (health)) {
			bloodbars [health].size = health.hp / health.maxHp; 
		}
	}
}
