using UnityEngine;
using System.Collections;

public class CameraController
: MonoBehaviour {

	public float followDistance;
	public float heightDistance;
	public Transform target;
	public Transform spawnTarget;
	public float chaseSpeed;
	private Vector3 camMovement = new Vector3 (0,0,0);
	
	// Use this for initialization
	void Start () {

		transform.position = new Vector3 (spawnTarget.position.x, spawnTarget.position.y, spawnTarget.position.z - heightDistance);

	}
	
	// Update is called once per frame
	void Update () {
		
		// set camaera to follow the target at a set distance
		//transform.position = new Vector3(target.position.x, target.position.y, target.position.z - heightDistance);
		
		
		
		
		/*
		if(target.position.y + followDistance > transform.position.y ){
			
			transform.position += camMovement * chaseSpeed * Time.deltaTime;
			
		}else if (target.position.y - followDistance < transform.position.y){
			
			transform.position -= camMovement * chaseSpeed * Time.deltaTime;
			
		}
		
		
		if(target.position.x + followDistance > transform.position.x ){
			
			transform.position += camMovement * chaseSpeed * Time.deltaTime;
			
		}else if (target.position.x - followDistance < transform.position.x){
			
			transform.position -= camMovement * chaseSpeed * Time.deltaTime;
			
		}*/
		
	}
}
