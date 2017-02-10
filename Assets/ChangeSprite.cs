using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

	// Public versions of these sprites
	public Sprite UpSprite;
	public Sprite DownSprite;
	public Sprite LeftSprite;
	public Sprite RightSprite;

	// The acutal sprite renderer on the object, what we'll use to change the sprite
	SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
		// Just getting the sprite renderer from our object 
		renderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		//ChangeSpriteFromVariables();
		LoadSpriteDynamically();
	}

	void ChangeSpriteFromVariables() {
		// If an arrow key is pressed, we change the sprite based on what's assigned
		if(Input.GetKey(KeyCode.UpArrow)) {
			renderer.sprite = UpSprite;
		}
		else if(Input.GetKey(KeyCode.DownArrow)) {
			renderer.sprite = DownSprite;
		}
		else if(Input.GetKey(KeyCode.LeftArrow)) {
			renderer.sprite = LeftSprite;
		}
		else if(Input.GetKey(KeyCode.RightArrow)) {
			renderer.sprite = RightSprite;
		}
	}

	void LoadSpriteDynamically() {

		// 
		if(Input.GetKey(KeyCode.UpArrow)) {
			renderer.sprite = Resources.Load<Sprite>("Corey");
		}
		else if(Input.GetKey(KeyCode.DownArrow)) {
			renderer.sprite = Resources.Load<Sprite>("Down");
		}
		else if(Input.GetKey(KeyCode.LeftArrow)) {
			renderer.sprite = Resources.Load<Sprite>("Left");
		}
		else if(Input.GetKey(KeyCode.RightArrow)) {
			renderer.sprite = Resources.Load<Sprite>("Right");
		}
	}
}
