﻿using UnityEngine;
using System.Collections;

public class KameraJalan : MonoBehaviour {
	private GameObject kamera;
	private float moveSpeed = 25f;
	//private Vector3 posKamera;

	public GameObject target;
	public GameObject hindari1;
	public GameObject hindari2;
	public GameObject hindari3;

	private int flag;

	// Use this for initialization
	void Start () {
		kamera = GetComponent <GameObject> ();
		flag = 0;
		//
	}
	
	void Update()
	{
		Vector3 newPosition = transform.position;
		if (newPosition.y <= 8.99f) {
			transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);
			//kamera.GetComponent<KameraJalan> ().enabled = true;
		} else {
			if(flag == 0)
			{
				create ();
				flag = 1;
			}
				
		}
			//kamera.GetComponent<createObject> ().enabled = true;
			
	}

	void create()
	{
		Vector3 position;
		Vector3 posKamera;
		posKamera = transform.position;
		Debug.Log("masuk");
		position = new Vector3(Random.Range(-18F, -2F), posKamera.y + Random.Range(1F, 5F), 0);
		hindari1.transform.position = position;
		position = new Vector3(Random.Range(-18F, -2F), posKamera.y + Random.Range(1F, 12F), 0);
		target.transform.position = position;
		position = new Vector3(Random.Range(-18F, -2F), posKamera.y + Random.Range(1F, 12F), 0);
		hindari2.transform.position = position;
		position = new Vector3(Random.Range(-18F, -2F), posKamera.y + Random.Range(1F, 12F), 0);
		hindari3.transform.position = position;
	}

}
