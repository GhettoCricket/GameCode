using UnityEngine;
using System.Collections;

public class Destruction : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision myCollision)
	{
		if(!myCollision.gameObject.CompareTag("Cubes"))
		{
			Destroy (gameObject);
			ScoreKeeper.Score++;
		}
		if(myCollision.gameObject.CompareTag ("Player"))
		{
			ScoreKeeper.Score--;
		}
	}
}
