using UnityEngine;
using System.Collections;

public class BallDestroyer : MonoBehaviour {

	public int []characterScores;
	public int num = 4;


	// Use this for initialization
	void Start () {
		characterScores = new int[num];
		for (int i = 0; i < characterScores.Length; i++) {
			characterScores[i] = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision other){
		Destroy(other.gameObject);
		if (this.gameObject.tag == "1") {
			setScoreA(100);
		}
		if (this.gameObject.tag == "2") {
			setScoreB(100);
		}
		if (this.gameObject.tag == "3") {
			setScoreC(100);
		}
		if (this.gameObject.tag == "4") {
			setScoreD(100);
		}
	}


	void setScoreA (int score){
		characterScores[0] += score;
		Debug.Log (score);
	}
	void setScoreB (int score){
		characterScores[1] += score;
		Debug.Log (score);
	}
	void setScoreC (int score){
		characterScores[2] += score;
		Debug.Log (score);
	}
	void setScoreD (int score){
		characterScores[3] += score; 
		Debug.Log (score);
	}

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,120,180), "Loader Menu");
		GUI.Label(new Rect(20, 70, 100, 50), "Score Player1 :" + characterScores[0]);
		GUI.Label(new Rect(20, 100, 100, 50), "Score Player2 :" + characterScores[1]);
		  
		GUI.Label(new Rect(20, 130, 100, 50), "Score Player3 :" + characterScores[2]);
		GUI.Label(new Rect(20, 160, 100, 50), "Score Player4 :" + characterScores[3]);
	}
}
