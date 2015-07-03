using UnityEngine;
using System.Collections;

public class PlayerScripts : MonoBehaviour {
	public float thrust = 100f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate (){
			if(Input.GetMouseButtonDown(0)){
			rb.AddForce(transform.forward * thrust);
		}
	}

}
