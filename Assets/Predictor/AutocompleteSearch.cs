using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AutocompleteSearch : MonoBehaviour
{

	public TextAsset book;
	
	List<string> words = new List<string> ();
	string myText = "";
	TextMesh textAutocomplete;
	private string suggestions = "";
	string outputs = "";
	string previousSuggestions = "";

	void Start ()
	{

		//make a new tokenizer object
		Tokeniser TK = new Tokeniser ();

		//get every word from the supplied text
		string[] stuff = TK.Partition (book.text);

		//for each word found, add it to our lookup list
		foreach (string x in stuff) {
			if (!words.Contains (x.ToLower ())) {
				words.Add (x.ToLower ());
			}
		}
	}

	void OnGUI ()
	{

		//keep a copy of previous suggestions
		previousSuggestions = suggestions;

		//this is the suggestion box
		suggestions = GUI.TextArea (new Rect (10, 50, 200, 200), suggestions);

		outputs = "";

		//this is the input field
		myText = GUI.TextField (new Rect (10, 10, 200, 20), myText);

		//if the textbox isn't empty
		if (!string.IsNullOrEmpty (myText)) {
			//find all words that start with your input
			List<string> found = words.FindAll (w => w.StartsWith (myText.ToLower ()));

			//if you found at least one word...
			if (found.Count > 0) {
				foreach (string x in found) {
					//build up your string... or do something for each
					//word found here.
					outputs += x + "\n";
				}

				//Set the suggestions to match your output
				suggestions = outputs;
				print (outputs);
			} else {
				suggestions = previousSuggestions;
			}

		} else {
			suggestions = "";
		}

	}
}