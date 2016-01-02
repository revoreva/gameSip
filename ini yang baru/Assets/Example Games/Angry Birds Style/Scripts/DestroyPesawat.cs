using UnityEngine;
using System.Collections;

public class DestroyPesawat : MonoBehaviour {

	private SpriteRenderer spriteRenderer;
	public float damageImpactSpeed;
	private float damageImpactSpeedSqr;	

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent <SpriteRenderer> ();
		Debug.Log("Hello");
		damageImpactSpeedSqr = damageImpactSpeed * damageImpactSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Debug.Log("Hello-hallo");

		if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr) {
			Destroy(collision.gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D other){
		Debug.Log("Hello-hallo-hallo");
		if (other.gameObject.tag == "capit") {
			//Destroy(other.gameObject);
			Application.LoadLevel("main");
		}
	}
}
