using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning_balls : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("multiplyBalls", 1.0f, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void multiplyBalls(){
		Instantiate (ballPrefab, transform);
	}
}
