using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madLib : MonoBehaviour {
	private string[] adj = { "old" , "smelly" , "young" , "fat" };
	private string [] job = { "plumber" , "teacher" , "student" };
	private string [] age = { "18" , "50" , "90" , "110" };
	private string [] verb = { "walk" , "run" , "swim" , "driving" };
	private string[] accident = { "crash", "fell", "died" };

	// Use this for initialization
	void Start () {
		
		RandmomNum = Random.Range (adj);
		RandmomNum = Random.Range (job);
		RandmomNum = Random.Range (age);
		RandmomNum = Random.Range (verb);
		RandmomNum = Random.Range (accident);


		print ("Once upon a time, there was a " + adj + ":" + job + "who was " +
			"a young" + age + "one day the man was" + verb + "and he " + 
			accident + "THE END");
	}
}
