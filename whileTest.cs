using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileTest : MonoBehaviour {

	public int minRange = 0;
	public int maxRange = 100;
	public int target = 36;
	private int counter = 0;

	// Use this for initialization
	void Start () {

		while (true) 
		{
			int guess = Random.Range (minRange, maxRange);
			counter++;

			if (guess == target) {
				print ("attempt" + counter + "is correct");
				break;
			} else if (guess < target) {
				print ("Attempt" + counter + "is too low");
				minRange = guess;
			} else 
			{
				print ("Attempt" + counter + "is too high");
				maxRange = guess;
			}
		}
		print ("you won.");
	}
}
