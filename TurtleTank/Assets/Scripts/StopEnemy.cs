using UnityEngine;
using System.Collections;

public class StopEnemy : MonoBehaviour {

	void onTriggerEnter (Collider enemy)
	{
		if(enemy.tag == "enemy")
		{
			enemy.attachedRigidbody.velocity = new Vector3(0,0,0);

		}
	}
}
