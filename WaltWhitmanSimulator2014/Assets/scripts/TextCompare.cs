using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextCompare : MonoBehaviour {
	public Keycounter letterstorage;
	public string poetry;
	public TextMesh poetryDisp;
	public List<Poem> allThePoems;

	private bool finished;

	void Start () {
		TextAsset file = (TextAsset)Resources.Load("LeavesOfGrass", typeof(TextAsset));
		poetry = file.text;
		//poetryDisp.text = poetry;
		allThePoems = new List<Poem> ();
		string[] poemArray = poetry.Split('#');
		foreach (string fullPoem in poemArray) 
		{
			allThePoems.Add(new Poem(fullPoem));
		}
		foreach (Poem debugFullPoems in allThePoems) 
		{
			//Debug.Log("title: " + debugFullPoems.title);
			//Debug.Log(debugFullPoems.bodyText);
		}
		//poetry.Split
	}
	
	// Update is called once per frame
	void Update () {
		if ((letterstorage.t.timer < 0f) && !finished) 
		{
			CheckForWin();
		}
	}

	void CheckForWin()
	{
		finished = true;
		int index = Random.Range (0, allThePoems.Count);
		int startIndex = index;
		bool fail = false;

		while (!(allThePoems[index].mashSuccess(letterstorage.lettercount, letterstorage.letters))) 
		{
			index++;

			if (index >= allThePoems.Count)
			{
				index = 0;
			}

			if(index == startIndex)
			{
				fail=true;
				break;
			}
		}

		if (fail) 
		{
			Debug.Log ("Walt is dissapoint");
		}
		else 
		{
			Debug.Log (allThePoems[index].title);
			Debug.Log (allThePoems[index].bodyText);
		}
	}
}







