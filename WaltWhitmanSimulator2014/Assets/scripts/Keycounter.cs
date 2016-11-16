using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Keycounter : MonoBehaviour {
	public Timer t;
	public Dictionary<char, int> letters = new Dictionary<char, int> ();	
	public int lettercount;

	// Use this for initialization
	void Start () {
		letters = new Dictionary<char, int> ();				
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyUp(KeyCode.Space))
		//	Debug.Log("Space key was released");
		//if (Input.GetKeyUp(KeyCode.A))
		//	Debug.Log("A key was released")
		//	storage[0];
		if (t.timer > 0f) {
			for (int i=0; i<26; ++i) {
				if (Input.GetKeyUp (KeyCode.A + i)) {
					char letter = (char)((int)'a' + i);
					lettercount++;
					if(letters.ContainsKey(letter))
					{
						letters[letter]++;
					}
					else
					{
						letters.Add(letter,1);
					}
				}
			}
		}
	}
}
