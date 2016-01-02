using UnityEngine;
using System.Collections;

public class KameraJalan : MonoBehaviour {
	private GameObject kamera;
	private float moveSpeed = 5f;
	// Use this for initialization
	void Start () {
		kamera = GetComponent <GameObject> ();
	}
	
	void Update()
	{
		Vector3 newPosition = transform.position;
		transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
	}
}
