using UnityEngine;
using System.Collections;

public class wallRotation : MonoBehaviour {

	private float targetRotateX;
	private float targetRotateY;
	private float targetRotateZ;
	
	private Vector3 currentRotate;
	// Use this for initialization
	void Start () {
		targetRotateX = 0;
		targetRotateY = 0;
		targetRotateZ = 0;
		currentRotate = new Vector3(0,0,0);
		
		EventManager.TriggerT.AddListener (() => {
			targetRotateY += 90;
		});
		// Eボタンが押された時
		EventManager.TriggerE.AddListener (() => {
			targetRotateY -= 90;
		});
		// Aボタンが押された時
		EventManager.TriggerA.AddListener (() => {
			 targetRotateX += 180;
		});
		// Mボタンが押された時
		EventManager.TriggerM.AddListener (() => {
			targetRotateZ += 180;
		});
	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown("a")){
			Debug.Log("aaa");
			targetRotateY += 90;
			//  while(targetRotateY > 360) targetRotateY  = 360;
		}
		if(Input.GetKeyDown("x")){
			targetRotateY -= 90;
		}
		if(Input.GetKeyDown("s")){
			targetRotateX += 180;
			//  while(targetRotateX > 360) targetRotateX = 360;
		}
		if(Input.GetKeyDown("d")){
			targetRotateZ += 180;
			//  while(targetRotateZ > 360) targetRotateZ = 360;
		}*/
		// Tボタンが押された時
		
		
		currentRotate.x = currentRotate.x * 0.8f + targetRotateX * 0.2f;
		currentRotate.y = currentRotate.y * 0.8f + targetRotateY * 0.2f;
		currentRotate.z = currentRotate.z * 0.8f + targetRotateZ * 0.2f;
		transform.eulerAngles = currentRotate;
		//  transform.rotation = Quaternion.Euler(45, 45, 0);
	}
}
