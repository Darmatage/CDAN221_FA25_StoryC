using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{

	public Rigidbody2D rb;
	public float moveSpeed = 5f;
	public Vector2 movement;
	public GameHandler_tree gameHandlerObj;
	public GameObject hitVFX;

	public GameObject instruct;
	private bool hasTouched = false;

	private bool moveLeftOn = false;
	private bool moveRightOn = false;
	private bool moveUpOn = false;
	private bool moveDownOn = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		if (GameObject.FindWithTag("GameHandler_tree") != null)
		{
			gameHandlerObj = GameObject.FindWithTag("GameHandler_tree").GetComponent<GameHandler_tree>();
		}
		instruct.SetActive(true);
	}

	void FixedUpdate()
	{
		//keyboard input:
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		//movement buttons:
		if (moveLeftOn) { movement.x = -1; }
		if (moveRightOn) { movement.x = 1; }
		if (moveUpOn) { movement.y = 1; }
		if (moveDownOn) { movement.y = -1; }

		//paddle movement:
		rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

			//turn off insructions when player touches a key:
			if (!hasTouched)
			{
			if (
				(Input.GetKeyDown("a")) ||
				(Input.GetKeyDown("d")) ||
				(Input.GetKeyDown("left")) ||
				(Input.GetKeyDown("right")) ||
				(moveLeftOn) || (moveRightOn)
			)
			//if (Input.GetAxisRaw("Horizontal") != null)
			{
				instruct.SetActive(false);
				hasTouched = true;
			}
			}
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "tree")
		{
			gameObject.GetComponent<AudioSource>().Play();
			GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
			StartCoroutine(DestroyVFX(boomFX));

			Destroy(other.gameObject);
			gameHandlerObj.AddScore(1);
		}
		if (other.gameObject.tag == "eviltree")
		{
			gameObject.GetComponent<AudioSource>().Play();
			GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
			StartCoroutine(DestroyVFX(boomFX));

			Destroy(other.gameObject);
			gameHandlerObj.AddScore(-5);
		}
	}

	IEnumerator DestroyVFX(GameObject theEffect)
	{
		yield return new WaitForSeconds(0.5f);
		Destroy(theEffect);
		gameObject.GetComponent<AudioSource>().Stop();
	}

	public void MoveLeft(){moveLeftOn = true;}
	public void MoveLeftOff(){moveLeftOn = false;}
	public void MoveRight(){moveRightOn = true;}
	public void MoveRightOff(){moveRightOn = false;}
	public void MoveUp(){moveUpOn = true;}
	public void MoveUpOff(){moveUpOn = false;}
	public void MoveDown(){moveDownOn = true;}
	public void MoveDownOff(){moveDownOn = false;}

}