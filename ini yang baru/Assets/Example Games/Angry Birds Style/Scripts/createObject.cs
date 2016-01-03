using UnityEngine;
using System.Collections;

public class createObject : MonoBehaviour {
	public GameObject target;
	public GameObject hindari1;
	public GameObject hindari2;
	public GameObject hindari3;

	// Use this for initialization
	void Start () {
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
		//Instantiate(target, position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
