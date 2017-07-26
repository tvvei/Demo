using UnityEngine;

[RequireComponent (typeof(Health))]
public class Bloodbar : MonoBehaviour
{
	void Start ()
	{
		BloodbarManager.Instance.AddBloodbar (this);
	}
}
