using UnityEngine;
using System.Collections;

public class entrandoAlNivel : MonoBehaviour
{
	public bool onPause = false;

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log("Has entrado a la Tierra");

		Application.LoadLevel("earthLevel");
		//Time.timeScale = 0.0f; PAUSA EL JUEGO, PARA MOSTRAR EL MENU DE QUE SI QUIERE UNO ENTRAR O NO A LA TIERRA.
		onPause = true;
	}

	void OnGUI()
	{
		if(onPause == true)
		{
			GUI.Label(new Rect(100, 100, 1000, 200), "ENTRANDO A LA TIERRA");
		}
	}
}
