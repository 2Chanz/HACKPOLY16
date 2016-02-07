using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;

	void Start ()
	{
		if (gm == null) {
			gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
		}
	}
	public Transform playerPrefab;
	public Transform spawnPoint;
	//public Transform spawnPrefab;
	public AudioClip spawnsound;



	public float spawnDelay = 2;

	public IEnumerator RespawnPlayer(){
		Debug.Log ("ToDo: Add waiting for spawn sound");
		AudioSource.PlayClipAtPoint (spawnsound, spawnPoint.position);
		yield return new WaitForSeconds (spawnDelay);
		Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
		//GameObject clone = Instantiate (spawnPrefab, spawnPoint.position, spawnPoint.rotation) as GameObject;
		//Destroy (clone, 3f);
		//Debug.Log ("Todo: Add Spawn Particles");

	}
	public static void KillPlayer (TankControls player) {
		Destroy (player.gameObject);
        
		gm.StartCoroutine(gm.RespawnPlayer());
	}

	public static void KillEnemy (){
		
	}


}