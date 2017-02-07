using System.Collections;
using UnityEngine;

public class variableoperation : MonoBehaviour {
	private float pi = 3.1415f;
	private float radius = 2.5f;
	private float length = 1.5f;
	private float width = 2.5f;
	private float base1 = 3.3f;
	private float hight = 4.3f; 
	// Use this for initialization
	void Start () {
		//find the diameter of a circle
		float diameter = 2 * radius;
		print ("The diameter of the circle is " + diameter);

		//find the circumfrence of a circle
		float circumfrence = pi * diameter;
		print ("The circumfrence of a circle is " + circumfrence);

		//find area of a circle
		float area = pi * radius * radius;
		print ("The area of a circle is " + area);

		//find the volume of a sphere
		float volume = 4 / 3 * pi * radius * 3;
		print ("The volume of a sphere is " + volume);

		//find the perimeter of a rectangle
		float perimeter = 2 * length + 2 * width;
		print ("The perimeter of a rectangle is " + perimeter);

		//find the area of a rectangle
		float area2 = length * width;
		print ("The area of a rectangle is " + area2);

		//area of a triangle
		float area1 = base1 * hight / 2;
		print ("The area of a triangle is " + area1);
	}
}
