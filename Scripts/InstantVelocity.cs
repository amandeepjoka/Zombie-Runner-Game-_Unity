using UnityEngine;
using System.Collections;

public class InstantVelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;
	private Rigidbody2D body2D;
	void Awake () {
		body2D = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		body2D.velocity = velocity;
	}
}
