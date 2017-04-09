using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	public Vector2 veloc = new Vector2(-4, 0);
	public float range = 4;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D> ().velocity = veloc;
		this.transform.position = new Vector3(4.0f,
			this.transform.position.y - range * Random.value,
			this.transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
