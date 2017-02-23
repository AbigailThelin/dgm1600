using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileloop : MonoBehaviour {

	private int minVal = 0;
	private int maxVal = 10;
	private int radomNum;
	private int counter = 0;

	// Use this for initialization
	void Start () {
		randomNum = Random.Range (minVal, maxVal);

		while(true)
		{
			randomNum = Random.Range (minVal, maxVal);
			if (randomNum > 0) 
			{
				maxVal = randomNum;
			} 
			else if (radomNum < 0) 
			{
				minVal = randomNum;
			}

			counter++;
			print ("Attempt" + counter + " :" + minVal + " -" + maxVal);
			if (maxVal == 1 && minVal == -1) 
			{
				break;
			}

				
		}
	}
}
