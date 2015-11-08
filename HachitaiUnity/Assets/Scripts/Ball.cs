using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public GameObject ball;
	private GameObject instanceBall;
	private float randomX;
	private float randomZ;

	// Use this for initialization
	void Start () {
		instanceBall = null;
		randomX = 0f;
		randomZ = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("n")){
			instanceBall = (GameObject)Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
			instanceBall.GetComponent<Rigidbody>().AddForce(new Vector3(randomX, 0, randomZ) * Time.deltaTime);
			randomX = Random.Range(-1, 1);
			randomZ = Random.Range(-1, 1);
		}
	}
	
	/*void OnCollisionEnter(Collision other){
		Destroy(instanceBall);
		Debug.Log("collision");
	}*/
}
