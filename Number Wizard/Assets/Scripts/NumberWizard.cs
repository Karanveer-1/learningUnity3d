using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int lowerBound;
	int upperBound;
	int guess;

	// Use this for initialization
	void Start () {
		lowerBound = 1;
		upperBound = 1000;
		guess = 500;
		print("=======================================================================");
		print("Welcome to the Number Wizard.");
		print("Pick a number in your head, but don't tell me!");
		print("The highest you can choose is " + upperBound);
		print("The lowest you can choose is " + lowerBound);
		print("Is your number is higher or lower than " + guess + " ?");
		print("Press up arrow key for higher, down arrow key for lower and enter key for equal.");
		upperBound += 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won..!!");
			Start();
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			lowerBound = guess;
			guess = (upperBound + lowerBound)/2;
			print("Higher or lower than " + guess);
			print("Press up arrow key for higher, down arrow key for lower and enter key for equal.");
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			upperBound = guess;
			guess = (upperBound + lowerBound)/2;
			print("Higher or lower than " + guess);
			print("Press up arrow key for higher, down arrow key for lower and enter key for equal.");
		}


	}
}
