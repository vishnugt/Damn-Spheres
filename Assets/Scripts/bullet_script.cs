using UnityEngine;
using System.Collections;

public class bullet_script : MonoBehaviour {

	public GameObject player;
	
	//float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	float radius=2.7f;
	Vector3 movePosition;
	// Use this for initialization
	public float speed = 2f + ui_script.level;
	void Start () {
		
		float angle = Random.Range(0f, 2 * Mathf.PI);
		
		float x = Mathf.Cos(angle)*radius; 
		float y = Mathf.Sin(angle)*radius;
		
		 movePosition = new Vector3(x, y, 0);

	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 newPos = Vector3.MoveTowards(this.transform.position, movePosition, speed * Time.deltaTime);
		//this.transform.position = newPos;
	}
}
