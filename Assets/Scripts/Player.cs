using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Vector2 jumpForce = new Vector2(0, 300);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp ("space")) {
			this.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			this.GetComponent<Rigidbody2D> ().AddForce (jumpForce);
		}
		// Die by being off screen
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Die ();
	}
	void Die()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("MainScene");
		
		//Application.LoadLevel (Application.loadedLevel);
	}
}
