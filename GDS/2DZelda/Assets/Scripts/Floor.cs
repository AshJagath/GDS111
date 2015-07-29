using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	[ContextMenu("Reposition")]
	void Reposition()
	{
		var localPosition = transform.localPosition;
		transform.localPosition = new Vector3 (Mathf.RoundToInt (localPosition.x), Mathf.RoundToInt (localPosition.y), Mathf.RoundToInt (localPosition.z));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
