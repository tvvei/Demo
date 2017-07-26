using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
	public delegate void VoidDamageHandle (Health health);

	public event VoidDamageHandle OnDamageEvent;

	public float hp = 100;
	[HideInInspector]
	public float maxHp;

	void Start ()
	{
		maxHp = hp;
	}

	public void Damage (float damage)
	{
		hp -= damage;
		if (OnDamageEvent != null) {
			OnDamageEvent.Invoke (this);
		}
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}
}
