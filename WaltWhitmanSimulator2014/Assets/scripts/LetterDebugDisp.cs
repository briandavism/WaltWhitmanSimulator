using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LetterDebugDisp : MonoBehaviour {
	public Keycounter letterstorage;
	public TextMesh disp;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		disp.text = "";
		foreach(KeyValuePair<char,int> letterpair in letterstorage.letters)
		{
			disp.text += letterpair.Key + "=" + letterpair.Value + " ";
		}
	}
}
