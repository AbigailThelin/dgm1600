using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchstatments : MonoBehaviour {
	private string time = "animal";
	// Use this for initialization
	void Start () {
		//create a switch statment for how much time your pet needs to sleep
		switch ("animal")
		{
		case "cat":
			print("10 hours of sleep");
			break;
		case "dog":
			print("5 hours of sleep");
			break;
		case "bird":
			print("3 hours of sleep");
			break;
		case "snake":
			print ("12 hours of sleep");
			break;
		case "mouse":
			print ("3 hours of sleep");
			break;
		case "gerbel":
			print ("3 hours of sleep");
			break;
		case "chicken":
			print ("1 hour of sleep");
			break;
		case "fox":
			print ("5 hours of sleep");
			break;
		case "giraffe":
			print ("9 hours of sleep");
			break;
		case "alligator":
			print ("four hours of sleep");
			break;
		
		
		default:
			print ("Have them sleep when you sleep");
			break;
		}
	}
}

//a switch statemnt is like if statment so if you put in an animal then something else will come out of that like how I did. So if someone put in dog, then it would print out that a dog needs 8 hours of sleep.