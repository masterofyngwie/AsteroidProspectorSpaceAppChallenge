using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour {

	public Transform target;//El objeto target
	
	public float speedMod = 2.0f;//un modificador de velocidad.
	
	private Vector3 point;//la coordenada donde va a girar alrededor el objeto
	
	
	
	void Start () {
		
		point = target.transform.position;//conseguir las coordenadas del objetivo
		
		transform.LookAt(point);//hace al objeto con el script mirar hacia el objeto
		
	}

	
	
	void Update () {
		
		transform.RotateAround (point,new Vector3(0.0f,1.0f,0.0f),30 * Time.deltaTime * -speedMod);
		
	}

}
