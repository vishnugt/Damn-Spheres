using UnityEngine;
using System.Collections;

public class ui_script : MonoBehaviour {


	public GameObject player;
	public  GameObject bullet;
	public static int level = 1	;

	public static bool reinst = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		TextMesh levell = GameObject.Find("ui").GetComponent<TextMesh>();
		TextMesh score = GameObject.Find("score").GetComponent<TextMesh>();
		TextMesh highscoree = GameObject.Find("highscore").GetComponent<TextMesh>();
		levell.text = "Level " + level;
		score.text = "Score " + movement.coins_collected;
		highscoree.text = "Highscore " + movement.highscore;

		if (movement.coins_collected % (22 * level) == 0 && movement.coins_collected != 0)
		{
			level++;
			reinst = true;

			//reinstantiate
		}
	
}
}