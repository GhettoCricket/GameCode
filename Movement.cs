using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	Life.lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Input.GetAxis ("Horizontal"),0,0);
		
	}
	void OnCollisionEnter()
	{
		Life.lives--;
		if(Life.lives <= 0)
		{
			Destroy(gameObject);
		}
	}
	
	
	
		
	
}
