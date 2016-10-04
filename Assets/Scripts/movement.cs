using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("highscore", 0);
	}

	public static int highscore;
	public AudioClip collect;
	public AudioClip lose;
	public bool gameover = false;
	public bool positivea = true;
	float angle =0;
	float speed = (2 * Mathf.PI) / 1.30f; //2*PI in degress is 360, so you get 5 seconds to complete a circle
	float radius=2.7f;
	void Update()
	{

		if (!gameover) {
			if (Input.GetButtonDown ("Fire1")) {
			
				if (positivea)
					positivea = false;
				else
					positivea = true;
			}
			if (positivea)
				angle -= speed * Time.deltaTime;
			else
				angle += speed * Time.deltaTime;

			float x = Mathf.Cos (angle) * radius;
			float y = Mathf.Sin (angle) * radius;
			transform.position = (new Vector3 (x, y, 0));
		}

		if (gameover) 
		{
			if (Input.GetButtonDown ("Fire1")) {
				highscore = PlayerPrefs.GetInt ("highscore", 0);
				if ( coins_collected > highscore)
					PlayerPrefs.SetInt("highscore", coins_collected);
				ui_script.level = 1;
				coins_collected = 0;
				Application.LoadLevel(0);

			}
		}
		
		if (Input.GetButtonDown ("Cancel")) 
		{
			Application.Quit();
		}
	}
	public static int coins_collected = 0;
	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == "coin")
			
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			//AudioSource.PlayClipAtPoint(collect, transform.audio


			Destroy(collider.gameObject);
			coins_collected++;
		}

		if(collider.tag == "villain")
			
		{
			AudioSource.PlayClipAtPoint(lose, transform.position);
			//end game
			gameover = true;
			//Destroy(this.gameObject);
		}
	}

	void OnMouseDown()
	{
		if (positivea)
			positivea = false;
		else
			positivea = true;
	}


}
