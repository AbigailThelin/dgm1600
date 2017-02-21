using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class ifstatements : MonoBehaviour { 
	private int centerStreet = 10; 
	private int universityAvenue = 3; 
	private float iFifteen = 6.5f; 
	private float iEightyfive = 4.4f; 

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
		if (centerStreet < universityAvenue) 
			print ("University Avenue is a longer street than Center Street."); 

		{ 
			if (centerStreet == universityAvenue) 
				print ("These two streets are the same length."); 
		} 
		if(iFifteen != iEightyfive) 

			print("The two highways are equal in length."); 

		if (iFifteen == iEightyfive)  
		{ 
			print ("The two highways are the same in cleanliness."); 
		} 
		if (universityAvenue != centerStreet)  
		{ 
			print ("University Avenue is more cleanly than Center Street."); 
		} 
		if (universityAvenue > iEightyfive)  
		{ 
			print ("I80 is longer of a drvive than university Avenue."); 
		} 
		if (iFifteen < universityAvenue)  
		{ 
			print ("I15 is a longer drive than University Avenue."); 
		} 
		if (iEightyfive <= iFifteen)  
		{ 
			print ("On any given day i15 may be equal to or less the distance of i85."); 
		} 
		if (universityAvenue >= centerStreet)  
		{ 
			print ("On any given day, University Avenue is the same or more clean than Center Street"); 
		} 
		if (centerStreet != iEightyfive)  
		{ 
			print ("Just go walk to get some excersise."); 
		} 

	} 

}