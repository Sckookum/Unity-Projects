using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;


	void OnTriggerEnter (Collider player)
	{
		if (player.tag == "Player")
		{
			DestroyObject(gameObject);
			Instantiate(enemy); 

		}
	}

}
