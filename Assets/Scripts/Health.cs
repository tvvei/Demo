using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
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
		if (hp <= 0) {
			Destroy (gameObject);
		}
	}
}
