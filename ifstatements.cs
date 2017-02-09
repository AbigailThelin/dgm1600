using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifstatements : MonoBehaviour {
	private int A = 10;
	private int B = 3;
	private string name = "Joseph";
	private bool study = true;
	private float Gandalf = 6.5f;
	private float Sam = 4.4f;

	/*
	 * ==
	 * =
	 * <
	 * 
	 * .
	 * <=
	 * >=
	 */


	// Use this for initialization
	void Start () {
		if (Sam < Gandalf)
			print ("Same is never greater than Gandalf.");

		{
			if (Gandalf == Sam)
				print ("Gandalf is always greater.");
		}
		if(name != "Amber")
	
			print("My name is Joseph.");

		if (A == B) 
		{
			print ("A is equal to B");
		}
		if (A != B) 
		{
			print ("A is not equal to B");
		}
		if (A > B) 
		{
			print ("A is more than B");
		}
		if (A < B) 
		{
			print ("A is less than B");
		}
		if (A <= B) 
		{
			print ("A is less than or equal to B");
		}
		if (A >= B) 
		{
			print ("A is greater than or equal to B");
		}
		if (study != true) 
		{
			print ("GO STUDY YOU FOOL.");
		}
		
		}

}