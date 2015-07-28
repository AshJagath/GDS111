using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private float HInput;
	private float VInput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	



	}


	void FixedUpdate(){




		HInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		VInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;
	


		rigidbody2D.MovePosition (new Vector2(transform.position.x + HInput, transform.position.y + VInput));
		//igidbody2D.MovePosition (Vector2.right * HInput);

		//rigidbody.velocity.magnitude += -1 ;
	}

	void Move(){

		if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
			
			rigidbody2D.MovePosition (Vector2.up * (speed / 1000) *  Time.deltaTime );
			
		}

	}


}
