using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public Vector2 Velocity;
	// Use this for initialization
	void Start () {
		// Just modifying a bit to make things a little easier
		Velocity = Velocity * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Velocity.x, Velocity.y, 0);
	}
}
