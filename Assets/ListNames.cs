using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListNames : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		// Get our Text Component
		Text theText = GetComponent<Text>();

		// Load the text file
		TextAsset textFile = Resources.Load<TextAsset>("names");

		// This is just a fancy way to split the file into lines
		string[] nameList = textFile.text.Split('\n');

		// For each line, add the new name
		for(int i = 0; i < nameList.Length; i++) {
			theText.text = theText.text + nameList[i] + '\n';
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
