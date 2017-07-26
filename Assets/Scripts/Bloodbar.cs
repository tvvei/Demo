using UnityEngine;

[RequireComponent (typeof(Health))]
public class Bloodbar : MonoBehaviour
{
	[HideInInspector]
	public Health health;

	void Awake ()
	{
		health = GetComponent<Health> ();
	}

	void Start ()
	{
		BloodbarManager.Instance.AddBloodbar (this);
	}
}
