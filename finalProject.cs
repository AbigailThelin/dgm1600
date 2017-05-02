using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalProject : MonoBehaviour 
{
	public InputField field1;
	public InputField field2;
	public static int firstnumber = 10;
	public static int secondnumber = 1;
	public static string button;
	public static int operation;
	public int total;

	public void mathOp ()
	{
		//print (this.gameObject);
		//Get the string value of the pressed button and use to match to case values in switch satement.
		button = this.gameObject.name;
		switch (button) 
		{
		case "+":
			//Addition ();
			operation = 1;
			GetFirstNum();
			break;

		case "-":
			operation = 2;
			GetFirstNum ();
			//Subtraction ();
			break;

		case "*":
			operation = 3;
			GetFirstNum ();
			//Multiplication ();
			break;

		case "/":
			operation = 4;
			GetFirstNum ();
			//Division ();
			break;
		default:
			print ("Wrong input for math operator...");
			break;


		}


	}


	public void Addition ()
	{
		total = firstnumber + secondnumber;    	//display this roll in the input field
	
	}
	
		
	public void Subtraction()
	{

		total = firstnumber - secondnumber;

	}
		
		
	public void Multiplication()
	{
		
		total = firstnumber * secondnumber;
					
	}

	public void Division()
	{

		total = firstnumber / secondnumber;

	}

	public void GetFirstNum()
	{
		firstnumber = int.Parse (field1.text);
		print ("First Number: " + firstnumber);
		print ("Operation: " + operation);
	}

	public void Calculate()
	{
		
	}


}

