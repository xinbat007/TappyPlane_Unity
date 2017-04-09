using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject rocks;
	int score = 0;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 1.0f, 0.8f);
	}
	void OnGUI()
	{
		GUI.color = Color.black;
		GUILayout.Label ("Score: " + score);
	}
	void CreateObstacle()
	{
		Instantiate (rocks);
		score++;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
