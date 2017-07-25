using System.Collections;
using UnityEngine;

public enum PunchWay
{
	Direction,
	Coroutine,
}

public class DoPunch : MonoBehaviour
{
	public PunchWay punchWay;
	[MinMaxRange (0, 3)]
	public RangedFloat range = new RangedFloat (1, 1.5f);
	[Range (0, 5)]
	public float speed = 1;
	private int direction = 1;

	void Start ()
	{       
		if (punchWay == PunchWay.Coroutine) {
			StartCoroutine (Punch (Time.deltaTime));
		}
	}

	void Update ()
	{
		if (punchWay == PunchWay.Coroutine) {
			transform.Rotate (-Vector3.one);
		} else {
			transform.Rotate (Vector3.one);
		}

		if (punchWay == PunchWay.Direction) {
			if (transform.localScale.x > range.max) {
				direction = -1;
			} else if (transform.localScale.x < range.min) {
				direction = 1;
			}
			transform.localScale += direction * speed * Time.deltaTime * Vector3.one;
		}
	}

	IEnumerator Punch (float waitTime, int direction = 1)
	{
		while ((direction > 0 && transform.localScale.x <= range.max) || (direction < 0 && transform.localScale.x >= range.min)) {
			yield return new WaitForSeconds (waitTime);
			transform.localScale += direction * speed * Time.deltaTime * Vector3.one;
		}
		StartCoroutine (Punch (Time.deltaTime, -direction));
	}
}
