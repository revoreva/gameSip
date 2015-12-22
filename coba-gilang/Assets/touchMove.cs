using UnityEngine;
using System.Collections;

public class touchMove : MonoBehaviour {
    public GameObject panah;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    void onClick(GameObject ball)
    {
        Destroy(panah);
    }
}
