using UnityEngine;
using System.Collections;

public class EntrandoALaLuna : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log("Entrando a la fabulosa Tierra");
		Time.timeScale = 0.0f;
	}
}
