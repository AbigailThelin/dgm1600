using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatements : MonoBehaviour {
	private int worktime = 8;

	// Use this for initialization
	void Start () {
		if (worktime <= 9){
			print("Go to work right NOW.");
		}
		else if(worktime == 9){
			print ("Welcome to work.");
		}
		if (worktime <= 10){
			print("get ready for meeting with Jim.");
		}
		else if(worktime == 10){
			print ("Meeting with Jim.");
		}
		if (worktime <= 12){
			print("Make Lunch reservations for McDonalds.");
		}
		else if(worktime == 12){
			print ("Head to Lunch.");
		}
		if (worktime <= 1){
			print("Start finishing up lunch.");
		}
		else if(worktime == 12){
			print ("Head back to the workplace.");
		}
		if (worktime <= 15){
			print("Finish up your work so you can head home.");
		}
		else if(worktime == 15){
			print ("HEAD HOME");
		}

		}
}
 
//* if statements are true then it will go to the if statments print line, but if not it will go to the else if. There can be multiple else if statements in a block of code but there can only be one else statement at the end of a block of code. 
