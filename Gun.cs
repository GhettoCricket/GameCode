using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	public Rigidbody Capsule;
	public Transform barrel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space))
		{
			Rigidbody CapsuleInstance;
			CapsuleInstance = Instantiate (Capsule, barrel.position, barrel.rotation) as Rigidbody;
			CapsuleInstance.AddForce (barrel.up * 2500);
		}
	}
}
