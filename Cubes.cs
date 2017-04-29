using UnityEngine;
using System.Collections;

public class Cubes : MonoBehaviour {
	public float delay = 0.1f;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay,delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate(cube,new Vector3(Random.Range(-10,20),10,0),Quaternion.identity);

	}
	void OnCollisionEnter()
	{

	Destroy (gameObject);
	}
}
