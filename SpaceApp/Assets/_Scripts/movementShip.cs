using UnityEngine;
using System.Collections;

public class movementShip : MonoBehaviour {

	public float speed = 90f; 
	public Camera cameraPlane;

	public GUIText distMoonPlayer;
	public GUIText distEarthPlayer;

	public Transform moon;
	public Transform earth;
	
	void Start()
	{
		Debug.Log ("Plane pilot script added to: " + gameObject.name);
	}

	void Update()
	{
		//Distancia entre la luna y el Jugador.
		float distMoonP = Vector3.Distance(transform.position, moon.position); 
		distMoonPlayer.text = "Distance between Moon and Player: " + distMoonP;
		//Distancia entre la Tierra y el Jugador.
		float distEarthP = Vector3.Distance(transform.position, earth.position); 
		distEarthPlayer.text = "Distance between Earth and Player: " + distEarthP;
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;
		float bias = 0.80f;
		cameraPlane.transform.position = cameraPlane.transform.position * bias + moveCamTo * (1.0f - bias);
		cameraPlane.transform.LookAt(transform.position + transform.forward * 30f);

		transform.Translate(Vector3.forward * speed * Time.deltaTime);

		speed -= transform.forward.y * 50.0f * Time.deltaTime;

		if(speed < 35.0f)
		{
			speed = 35.0f;
		}
		else if(speed > 120.0f)
		{
			speed = 120.0f;
		}

		transform.Rotate(v,0.0f, -h);
	}
}
