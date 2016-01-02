using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public GameObject poros;
	public float rotateSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		Vector3 pivotRotate = poros.transform.position;

		transform.RotateAround(pivotRotate, Vector3.forward, -rotateSpeed * Time.deltaTime);
	}
}
