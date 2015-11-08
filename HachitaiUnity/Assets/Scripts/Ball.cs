using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public GameObject ball;
	private GameObject instanceBall;
	private float randomX;
	private float randomZ;
	private float instanceFrame;
	private float randomFrame;

	// Use this for initialization
	void Start () {
		instanceBall = null;
		randomX = 0f;
		randomZ = 0f;
		instanceFrame = 0f;
		randomFrame = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		instanceFrame++;
		if(instanceFrame >= randomFrame){
			instanceBall = (GameObject)Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
			instanceBall.GetComponent<Rigidbody>().velocity = transform.forward;
			randomX = Random.Range(-1, 1);
			randomZ = Random.Range(-1, 1);
			randomFrame = Random.Range(60f, 180f);
			instanceFrame = 0f;
		}
	}
	
	/*void OnCollisionEnter(Collision other){
		Destroy(instanceBall);
		Debug.Log("collision");
	}*/
}
