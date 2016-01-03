using UnityEngine;
using System.Collections;

public class waitGameOver : MonoBehaviour {
	private float time = 0.0f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(time <= 2)
		{
			time = time + Time.deltaTime;
			Debug.Log(time);
		}
		else
			Application.LoadLevel("Awal");
	}
}
