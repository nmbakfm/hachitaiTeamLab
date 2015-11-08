using UnityEngine;
using System.Collections;

public class InstanceBall : MonoBehaviour {
	public GameObject ball;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	  GameObject inc = (GameObject)Instantiate(ball, new Vector3(0, 7, 0), Quaternion.identity);
	  Destroy(inc, 3f);
	}
}
