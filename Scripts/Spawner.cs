using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject []prefabs;
	public float delay =2.0f;
	public bool active=true;
	public Vector2 delayRange= new Vector2(1,2);


	// Use this for initialization
	void Start () {
		ResetDelay ();
		StartCoroutine (EnemyGenerater());
	}

	void ResetDelay()
	{
		delay = Random.Range (delayRange.x,delayRange.y);
	}

	IEnumerator EnemyGenerater()
	{
		yield return new WaitForSeconds (delay);

		if(active)
		{
			var newtransform= transform;
			Instantiate(prefabs[Random.Range(0,prefabs.Length)],newtransform.position,Quaternion.identity);
			ResetDelay();
		}
		StartCoroutine (EnemyGenerater());
	}

	// Update is called once per frame
	void Update () {
	
	}
}
