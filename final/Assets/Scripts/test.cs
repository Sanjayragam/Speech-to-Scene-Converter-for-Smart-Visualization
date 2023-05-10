using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	
	float x1, x2, x3, y1, y2, y3, mx, my, nx, ny;



	Vector2 a;
	Vector2 b;
    
	// Use this for initialization
	public Vector2 getpoint (int i,float width) {

		if (i == 1) {
			
			a = new Vector2 (0, 0);
			return a;
		

		} else if (i == 2) {

			b = new Vector2 (width, 0);
			return b;
		} else {

			x1 = a.x;
			y1 = a.y;
			x2 = b.x;
			y2 = b.y;
			mx = (x1 + x2) / 2;
			my = (y1 + y2) / 2;
			nx = 0.866f * (y1 - y2);
			ny = 0.866f * (x2 - x1);
			x3 = mx + nx;
			y3 = nx + ny;
			a = b;
			b = new Vector2 (x3, y3);
			return b;

		}



       
		
	}

}
