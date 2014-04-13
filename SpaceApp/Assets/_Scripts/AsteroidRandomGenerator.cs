using UnityEngine;
using System.Collections;

public class AsteroidRandomGenerator : MonoBehaviour {

	public GameObject[] asteroids;

	// Use this for initialization
	void Start()
	{
		InvokeRepeating("GenerateAsteroids",1,8);
	}

	void Update()
	{
		print("Print: " + Time.time);
	}

	void GenerateAsteroids()
	{
		print("Print: " + asteroids[Random.Range(0,3)].name);
		Vector3 randomPosition = new Vector3(Random.Range(13f, 2030f),Random.Range(60, 70),Random.Range(22,2000));
		GameObject pepe;
		pepe = Instantiate(asteroids[Random.Range(0,3)],randomPosition, transform.rotation) as GameObject;
		int numRand = Random.Range(40,46);
		pepe.transform.localScale = Vector3.one * numRand;
	}    
}
