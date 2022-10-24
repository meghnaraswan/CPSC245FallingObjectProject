using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerNew : MonoBehaviour
{
	private int count;
	private GameControllerNew gameControllerNew;
	//bool isCollected = false;

	// Start is called before the first frame update
	void Start()
    {
		count = 0;
	}

	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	//void OnCollisionEnter2D(Collision2D other)
	//{
	//	//if (other.gameObject.tag.Equals("FallingObject"))
	//	//	isCollected = true;

	//	// ..and if the game object we intersect has the tag 'FallingObject' assigned to it..
	//	//if (other.gameObject.CompareTag("FallingObject"))
	//	//if (other.gameObject.name == "FallingObject(Clone)")
	//	if (other.gameObject.name == "FallingObject(Clone)")
	//	{
	//		// Make the other game object (the pick up) inactive, to make it disappear
	//		//other.gameObject.SetActive(false);

	//		Destroy(other.gameObject);
	//		Debug.Log("picked up object");

	//		// Add one to the score variable 'count'
	//		count = count + 1;

	//		// Run the GameControllerNew function for picking up a collectible
	//		gameControllerNew.OnPickUpFallingObject(count);
	//	}
	//}

	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	void OnTriggerEnter(Collider other)
	{
		// ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.name == "FallingObject(Clone)")
		{

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the GameController function for picking up a collectible
			gameControllerNew.OnPickUpFallingObject(count);

			Debug.Log("PlayerControllerNew: colliding");
		}
	}


}
