using UnityEngine;
using System.Collections;

public class DirectionScripts : MonoBehaviour {
	public Transform target;
	public Vector3 position;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(1)){
		transform.LookAt(Input.mousePosition);
		Debug.Log(Input.mousePosition);
		}
	}
}
