
using UnityEngine;

public class AISpawn : MonoBehaviour
{
	private GameObject ProperEnemy9;
	private int SpawnerID;
	// Used to find the parent spawner object
	void Start () {
		ProperEnemy9 = (GameObject) GameObject.FindWithTag ("Spawner");
	}
	// Call this when you want to kill the enemy
	void removeMe ()
	{
		ProperEnemy9.BroadcastMessage("killEnemy", SpawnerID);
		Destroy(gameObject);
	}
	// this gets called in the beginning when it is created by the spawner script
	void setName(int ProperEnemy9)
	{
		SpawnerID = ProperEnemy9;
	}
}