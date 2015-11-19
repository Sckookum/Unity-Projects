using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	// Use this for initialization
	Vector3 enemyspawnPoint;
	public Rigidbody rig;
	public float spawnDistance;
	public float enemySpeed;

	void Start () 
	{
		SpawnPoint ();
		rig = GetComponent<Rigidbody>();
		rig.velocity = new Vector3(enemySpeed,0,0);
	}


	void onTriggerEnter (Collider point)
	{
	 if(point.tag == "Cursor")
		{
			DestroyObject(gameObject);
		}
	}

	void SpawnPoint ()
	{
		enemyspawnPoint.x = Camera.main.transform.position.x + spawnDistance;
		enemyspawnPoint.y = Camera.main.transform.position.y;
		transform.position = enemyspawnPoint;
	}
}
