using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timer;
	public TextMesh timerText;
	// Use this for initialization
	void Start () {
		timer = 30f;
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer - Time.deltaTime;
		if (timer > 0f) {
			timerText.text = "" + (int)timer;
		} 
		else {
			timerText.text = "Fin";

		}
	}
}
