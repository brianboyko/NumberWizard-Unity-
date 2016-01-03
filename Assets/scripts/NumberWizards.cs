using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	// variable declaration
	int max;
	int min;
	int guess;

	// Use this for initialization
	void prompt (){
		print ("Is the number equal to, higher, or lower than " + guess + "?");
		print ("Up = higher, down = lower, return/enter = equal"); 
	}
	
	int adjustGuess(int max, int min){
		return Mathf.FloorToInt ((max + min) / 2);
	}
	
	void startGame (){
		max   = 1000; 
		min   = 1;
		guess = 500; 
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head, but don't tell me."); 
		
		print ("The highest number you can pick is " + max + "."); 
		print ("The lowest number you can pick is " + min + "."); 
		max = max + 1; 
		
		prompt ();	
	}
	
	void Start () {
		startGame ();	
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)){
			min = guess;
			guess = adjustGuess (max, min);
			prompt ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)){
			max = guess;
			guess = adjustGuess (max, min);
			prompt ();
		} else if (Input.GetKeyDown (KeyCode.Return)){
			print ("I won!");
			startGame ();
		}
	}
}
