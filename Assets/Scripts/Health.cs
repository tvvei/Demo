using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
	public float hp = 100;
	public Scrollbar scrollbar;
	private float maxHp;

	void Start ()
	{
		maxHp = hp;
		scrollbar.transform.position = gameObject.transform.position + Vector3.up;
	}

	void Update ()
	{
		scrollbar.transform.LookAt (Camera.main.transform);
	}

	public void Damage (float damage)
	{
		hp -= damage;
		scrollbar.size = hp / maxHp;
		if (hp <= 0) {
			Destroy (gameObject);
			Destroy (scrollbar.gameObject);
		}
	}
}
