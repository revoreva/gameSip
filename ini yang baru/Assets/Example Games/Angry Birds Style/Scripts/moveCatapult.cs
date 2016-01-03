using UnityEngine;
using System.Collections;

public class moveCatapult : MonoBehaviour {
	private float moveSpeed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		if(newPosition.y <= -2)
			transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
		//transform.RotateAround(pivotRotate, Vector3.forward, -turnSpeed * Time.deltaTime);        

	}
}
