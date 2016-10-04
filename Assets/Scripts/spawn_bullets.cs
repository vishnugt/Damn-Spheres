using UnityEngine;
using System.Collections;

public class spawn_bullets : MonoBehaviour {

	public GameObject bullet;
	public GameObject player;
	public GameObject villain;	
	private float nextActionTime2 = 0.11f;
	public float period2 = 0.1f;	

	// Use this for initialization
	void Start () {
			float radius = 2.7f;
			nextActionTime2 = 0.0f;
			for (float i = 0.0f; i < 6.4f; i += 0.3f) {
				
				float angle = i;
				float x = Mathf.Cos (angle) * radius;
				float y = Mathf.Sin (angle) * radius;
				Instantiate (bullet, new Vector3 (x, y, 0), Quaternion.identity);
			}
		}


	
	// Update is called once per frame
	void Update () {


		if (ui_script.reinst) {
			float radius=2.7f;
			nextActionTime2 = 0.0f;
			for (float i = 0.0f; i < 6.4f; i += 0.3f) 
			{
				
				float angle = i;
				float x = Mathf.Cos(angle)*radius;
				float y = Mathf.Sin(angle)*radius;
				Instantiate(bullet, new Vector3(x, y, 0), Quaternion.identity);
			}
			ui_script.reinst = false;
		} 


		if (Time.timeSinceLevelLoad > nextActionTime2 ) {
			nextActionTime2 += period2;
			Instantiate(villain, Vector3.zero, Quaternion.identity);
			
		}


	
	}
}
