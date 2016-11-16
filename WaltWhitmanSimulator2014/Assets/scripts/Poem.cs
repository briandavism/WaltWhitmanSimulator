using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Poem 
{
	public string bodyText;
	public string title;
	public Dictionary<char, int> letters;
	public int letterCount;

	public Poem (string poetryWords)
	{
		string[] titleAndBody = poetryWords.Split('*');
		title = titleAndBody [0];
		title = title.Trim ();
		bodyText = titleAndBody [1];
		bodyText = bodyText.Trim ();
		letters = new Dictionary<char, int> ();

		foreach (char letter in bodyText) 
		{
			char lowerLetter = char.ToLower(letter);
			if( char.IsLetter(lowerLetter) )
			{
				letterCount++;
				if(letters.ContainsKey(lowerLetter))
				{
					letters[lowerLetter]++;
				}
				else
				{
					letters.Add(lowerLetter,1);
				}
			}
		}
	}

	public bool mashSuccess(int mashLetterCount, Dictionary<char,int> mashLetters)
	{
		if(mashLetterCount<letterCount)
		{
			return false;
		}

		foreach (KeyValuePair<char,int> letterpair in letters) 
		{
			if(!mashLetters.ContainsKey(letterpair.Key))
			{
				return false;
			}

			if(mashLetters[letterpair.Key] < letterpair.Value)
			{
				return false;
			}
		}
		return true;
	}
}

