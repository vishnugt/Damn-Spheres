using UnityEngine;
using System.Collections;

public class villainscript : MonoBehaviour {
	
	public GameObject player;

	
	private float nextActionTime = 1f;
	public float period = 2.5f;	

	//float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	float radius=10f;
	Vector3 movePosition;
	// Use this for initialization
	public float speed = 2f +  ui_script.level;
	void Start () {
		
		int angle = Random.Range(0, 21);
		
		float x = Mathf.Cos(angle * 0.3f + 0.15f)*radius;
		float y = Mathf.Sin(angle * 0.3f + 0.15f)*radius;
		
		movePosition = new Vector3(x, y, 0);
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newPos = Vector3.MoveTowards(this.transform.position, movePosition, speed * Time.deltaTime);
		this.gameObject.transform.position = newPos;
	}
}
