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
		
		adj1 = Random.Range ( 0 , adj.Length);
		job1 = Random.Range (0 , job.Length);
		age1 = Random.Range (0 , age.Length);
		verb1 = Random.Range ( 0 , verb.Length);
		accident = Random.Range ( 0 , accident.Length);


		print ("Once upon a time, there was a " + adj1 + ":" + job1 + "who was " +
			"a young" + age1 + "one day the man was" + verb1 + "and he " + 
			accident1 + "THE END");
	}
}
