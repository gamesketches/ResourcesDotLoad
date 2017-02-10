using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// If the player hits space
		if(Input.GetKeyDown(KeyCode.Space)) {
			// Load all objects inside the "Bullets" folder in "Resources"
			GameObject[] objects = Resources.LoadAll<GameObject>("Bullets");
			// For each of those objects, create a copy in the game
			for(int i = 0; i < objects.Length; i++) {
				Instantiate(objects[i]);
			}
		}
	}
}
