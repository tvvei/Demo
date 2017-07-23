using UnityEngine;

public class PlayerController : MonoBehaviour
{
	static private PlayerController instance;

	static public PlayerController Instance {
		get {
			return instance;
		}
	}

	public Rigidbody rigid;
	[Range (0f, 20f)]
	public float force = 5f;
	public Vector2 axis;

	void Awake ()
	{
		instance = this;
	}

	void Start ()
	{
		rigid = rigid ?? GetComponent<Rigidbody> ();	
	}

	void Update ()
	{
		
		rigid.AddForce (new Vector3 (axis.x, 0, axis.y) * force);
	}

	public void AddForce (float h, float v)
	{
		axis.x = h;
		axis.y = v;
	}
}
