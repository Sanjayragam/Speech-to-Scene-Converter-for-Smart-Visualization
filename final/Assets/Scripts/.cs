using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
public class Relation : MonoBehaviour {

float pheight;
float pwidth;
float cheight;
float cwidth;
float clength;
float plength;
int leftbetween;
GameObject parent;
GameObject child;
GameObject model;
string pname;
string cname;
string colormodel;
string mname;
string oname;
char[] lastchar;
public string colorvar;

Vector3 scale;
public float objectSize = 3.0f;



public void color()
{

	string sent_count = @"C:/Main Project/main/final/count.txt";
	string text_count = File.ReadAllText(sent_count);
	var sentences = Int16.Parse(text_count);
	// Debug.Log(sentences);
	for (int k = 1; k <= sentences; k++) {
  		string Path = "C:/Main Project/main/final/promptformatted" + k + ".txt";
  		// Debug.Log(Path);
  		string sentence_file = File.ReadAllText(Path);
  		var count = -1;
  		string[] sent = sentence_file.Split(Environment.NewLine);
  		foreach(string sent_line in sent) {
    		count = count + 1;
    		// Debug.Log(sent_line);

  		}
		
  		string[] parts = new string[count];

  		for (int j = 0; j < count; j++) {
    		parts[j] = sent[j];
  		}

  		for (int j = 0; j < count; j++) {
			// Debug.Log(j+"-"+parts[j]);
			colorvar=parts[j];
  		}

		// Debug.Log(count);
		// Debug.Log(parts[1]);

		// Debug.Log(parts[count-1]);

		// pname=parts[count-2];

		if(parts[count-1]=="1.red" || parts[count-1]=="1.yellow" || parts[count-1]=="1.green" || parts[count-1]=="1.blue" || parts[count-1]=="1.black")
		{

			var color=parts[count-1];
			mname=parts[count-2];
			string[] colorname = mname.Split(".");
			string colorobject = colorname[1];
			char lastCharacter = colorobject[colorobject.Length - 1];
		

			if(Char.IsDigit(lastCharacter))
			{
				colormodel = colorobject;
			}

			else
			{
				colormodel = colorobject+"1";
			}
			

			Debug.Log(colormodel);
			// Debug.Log(colorobject);
			GameObject objecttocolor= GameObject.Find(colormodel);
			Material newMat = Resources.Load(color, typeof(Material)) as Material;
			objecttocolor.GetComponent<Renderer>().material = newMat;

		}



		var object_to_scale=parts[count-2];
		var measure=parts[count-1];
		string[] measurevalue = measure.Split(".");
		string[] object_name = object_to_scale.Split(".");
		// Debug.Log(measurevalue[1]);
		
			//convert to table1 concatenate 1

		char lastChar = object_name[1][object_name[1].Length - 1];

		if(Char.IsDigit(lastChar))
		{
			oname = object_name[1];
		}

		else
		{
			oname = object_name[1]+'1';
		}

		// Debug.Log(oname);

		

		if(parts[0]=="height" && measurevalue[1]=="metre" || measurevalue[1]=="meter")
		{	
			var scalevalue = Int16.Parse(measurevalue[0]);
			Debug.Log(scalevalue);

			GameObject rotater = GameObject.Find(oname);
			scale = transform.localScale;
        	scale.y = scalevalue;
        	rotater.transform.localScale = scale;

			float height = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			float width = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.x;

            GameObject.Find(oname).transform.position = new Vector3(0,height/2,0);
		}

	

		// if(parts[0]=="width" && measurevalue[1]=="meter")
		// {	
		// 	var scalevalue = Int16.Parse(measurevalue[0]);
		// 	Debug.Log(scalevalue);

		// 	GameObject rotater = GameObject.Find(oname);
		// 	scale = transform.localScale;
        // 	scale.x = scalevalue;
        // 	rotater.transform.localScale = scale;
		// }


}
}	
	
public void relate()
{
	

		try {
		
		if (true) 
		{
			

			string sent_count = @"C:/Main Project/main/final/count.txt";
    		string text_count = File.ReadAllText(sent_count);
    		var sentences=Int16.Parse(text_count);
    		// Debug.Log(sentences);

    		for (int k = 1; k <=sentences; k++) 
    		{
      			string Path="C:/Main Project/main/final/promptformatted"+k+".txt";
      			// Debug.Log(Path);
      			string sentence_file = File.ReadAllText(Path);
      			var count=-1;
      			string[] sent = sentence_file.Split(Environment.NewLine);
      			foreach (string sent_line in sent) {
        			count=count+1;
        			// Debug.Log(sent_line);
        
      			}


      			string[] parts = new string[count];
    
      			for (int j = 0; j <count; j++) 
		  		{
  		  			parts[j]=sent[j];
		  		}

      			foreach (string part in parts) {
        			// Debug.Log(part);	
      			}

				string[] left = parts [0].Split ('.');
				string[] right = parts [2].Split ('.');
				

				// string[] measureleft = parts [1].Split(".");
				// var leftbetween = measureleft[0];
				// Debug.Log(leftbetween);


				// if(measureleft[1]=="meter" && parts [2]=="1.left")
				// {

				// 	int x =Int32.Parse(left [0]);
				// 	lastchar = right[1].TrimEnd().ToCharArray();
				// 	if(!Char.IsNumber(lastchar[0]))
				// 	{
				// 		pname=right[1]+"1";
				// 	}

				// 	for(int i=0;i<x;i++)
				// 	{

				// 		Debug.Log("set");
				// 		Debug.Log(pname);
				// 		cname=parts[0];

				// 		cname=left[1]+(i+1).ToString();
				// 		parent= GameObject.Find (pname);
				// 		child=GameObject.Find (cname);
				// 		Debug.Log(cname);
				// 	}
				

				// }

				string[] partss = parts [1].Split(".");
				var partsss = partss[1];
			
				switch (partss[1]) {
				

				case "on":
				case "above":


					List<GameObject> childs = new List<GameObject>();
					int x=Int32.Parse(left [0]);
					// lastchar = right[1].TrimEnd().ToCharArray();

					// if(!Char.IsNumber(lastchar[0]))
					// {
					// 	pname=right[1]+"1";
					// }

					// Debug.Log(pname);


					// Debug.Log(right[1]);

					char lastChar = right[1][right[1].Length - 1];

					// Debug.Log(lastChar);


					if(Char.IsDigit(lastChar))
					{
						pname = right[1];
					}

					else
					{
						pname = right[1]+'1';
					}

					Debug.Log(pname);

					for(int i=0;i<x;i++)
					{
					// Debug.Log(pname);

					



					cname=left[1]+(i+1).ToString();
					parent= GameObject.Find (pname);
					child=GameObject.Find (cname);
					
		
					if(pname=="chair1")
					{
						pheight=0.45F;
					}
					else
					{
						pheight = parent.GetComponent<Renderer> ().bounds.size.y;
					}
					
					Debug.Log(pheight);

					cheight = child.GetComponent<Renderer> ().bounds.size.y;

					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;
					child.transform.position+= new Vector3 (0,0,0);
					child.transform.position+= new Vector3 (parentposition[0],pheight,parentposition[2]);

					
					// Debug.Log(parentposition[1]);

					childs.Add(child);


					}
					break;



				case "front":
				case "infront":


					List<GameObject> childss = new List<GameObject>();
					int y=Int32.Parse(left [0]);
			
					char lastChars = right[1][right[1].Length - 1];

				
					if(Char.IsDigit(lastChars))
					{
						pname = right[1];
					}

					else
					{
						pname = right[1]+'1';
					}

					Debug.Log(pname);

					for(int i=0;i<y;i++)
					{
	
					cname=left[1]+(i+1).ToString();
					parent= GameObject.Find (pname);
					child=GameObject.Find (cname);

					pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
					cwidth = child.GetComponent<Renderer> ().bounds.size.z;
					var position=((pwidth/2)+(cwidth/2))*1;
					
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					// child.transform.position+= new Vector3 (0,0,0);
					child.transform.position+= new Vector3 (0,0,parentposition[2]);
					child.transform.position+= new Vector3 (parentposition[0],0,-(position));
			
					childss.Add(child);


					}
					break;






					case "back":
					case "behind":


					List<GameObject> childsss = new List<GameObject>();
					int z=Int32.Parse(left [0]);
					char lastCharss = right[1][right[1].Length - 1];

					if(Char.IsDigit(lastCharss)){
						pname = right[1];
					}
					else{
						pname = right[1]+'1';
					}

					for(int i=0;i<z;i++){

						cname=left[1]+(i+1).ToString();
						parent= GameObject.Find (pname);
						child=GameObject.Find (cname);
					
		
					pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
					cwidth = child.GetComponent<Renderer> ().bounds.size.z;
					var position=((pwidth/2)+(cwidth/2))*1;
					
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (0,0,parentposition[2]);
					child.transform.position+= new Vector3 (parentposition[0],0,position);
				
					childsss.Add(child);


					}
					break;




					case "left":
					case "left side":


					List<GameObject> childsl = new List<GameObject>();
					int a=Int32.Parse(left [0]);
					char lastCharsl = right[1][right[1].Length - 1];

					if(Char.IsDigit(lastCharsl)){
						pname = right[1];
					}
					else{
						pname = right[1]+'1';
					}

					for(int i=0;i<a;i++){

						cname=left[1]+(i+1).ToString();
						parent= GameObject.Find (pname);
						child=GameObject.Find (cname);
					
		
					plength = parent.GetComponent<Renderer> ().bounds.size.x;
					clength = child.GetComponent<Renderer> ().bounds.size.x;
		
					var position=(plength/2+clength/2)+1/2;
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (parentposition[0],0,0);
					child.transform.position+= new Vector3 (position,0,parentposition[2]);

				
					childsl.Add(child);


					}
					break;



					case "right":
					case "right side":


					List<GameObject> childsr = new List<GameObject>();
					int b=Int32.Parse(left [0]);
					char lastCharsr = right[1][right[1].Length - 1];

					if(Char.IsDigit(lastCharsr)){
						pname = right[1];
					}
					else{
						pname = right[1]+'1';
					}

					for(int i=0;i<b;i++){

						cname=left[1]+(i+1).ToString();
						parent= GameObject.Find (pname);
						child=GameObject.Find (cname);
					
		
					plength = parent.GetComponent<Renderer> ().bounds.size.x;
					clength = child.GetComponent<Renderer> ().bounds.size.x;
		
					var position=(plength/2+clength/2)+1/2;
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (parentposition[0],0,0);
					child.transform.position+= new Vector3 (-(position),0,parentposition[2]);

				
					childsr.Add(child);


					}
					break;









				






				// case "near":


				// x=Int32.Parse(left [0]);

				// lastchar = right[1].TrimEnd().ToCharArray();

				// if(!Char.IsNumber(lastchar[0]))
				// {
				// 	pname=right[1]+"1";
				// }

				// for(int i=0;i<x;i++)
				// {
				// 	string cname=left[1]+(i+1).ToString();
				// 	parent= GameObject.Find (pname);
				// 	child=GameObject.Find (cname);

				// 	pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
				// 	cwidth = child.GetComponent<Renderer> ().bounds.size.z;

				// 	var position=((pwidth)+(cwidth))*1;
				// 	// Debug.Log(position);

				// 	Transform parentTransform = parent.transform;
				// 	Vector3 parentposition = parentTransform.position;

				// 	child.transform.position+= new Vector3 (parentposition[0],0,parentposition[2]);
				// 	child.transform.position+= new Vector3 (position,0,parentposition[2]);
				// 	// child.transform.position+= new Vector3 (0,0,5);
				
				// }
				// break;


				// case "left":
				// case "left side":
				// case "near":
	
				// string[] measureleft = parts [1].Split(".");
				// Debug.Log(measureleft[1]);
				// if(measureleft[1]=="left" && Int32.Parse(measureleft[0])>1){
				// 	leftbetween = Int32.Parse(measureleft[0]);
				// 	Debug.Log(leftbetween);
				// }
				// else{
				// 	leftbetween = 0;
				// 	Debug.Log(leftbetween);
				// }
	
				


				// x=Int32.Parse(left [0]);
				// lastchar = right[1].TrimEnd().ToCharArray();
				// if(!Char.IsNumber(lastchar[0]))
				// {
				// 	pname=right[1]+"1";
				// }

				// for(int i=0;i<x;i++)
				// {
				// 	string cname=left[1]+(i+1).ToString();
				// 	parent= GameObject.Find (pname);
				// 	child=GameObject.Find (cname);
				// 	plength = parent.GetComponent<Renderer> ().bounds.size.x;
				// 	clength = child.GetComponent<Renderer> ().bounds.size.x;
				// 	var position=(plength/2+clength/2)+leftbetween;
				// 	Transform parentTransform = parent.transform;
				// 	Vector3 parentposition = parentTransform.position;
					
				// 	child.transform.position+= new Vector3 (parentposition[0],0,0);
				// 	child.transform.position+= new Vector3 (position,0,parentposition[2]);


				// 	// if(leftbetween>=1){
				// 	// 	child.transform.position+= new Vector3 (parentposition[0]+position,0,0);
				// 	// }
				// 	// else{
				// 	// 	var position=(plength/2+clength/2)+1/2;
				// 	// }
						
					
					
				
				// }
				// break;






				


				// case "right":

				// x=Int32.Parse(left [0]);
				// lastchar = right[1].TrimEnd().ToCharArray();
				// if(!Char.IsNumber(lastchar[0]))
				// {
				// 	pname=right[1]+"1";
				// }

				// for(int i=0;i<x;i++)
				// {
				// 	string cname=left[1]+(i+1).ToString();
				// 	parent= GameObject.Find (pname);
				// 	child=GameObject.Find (cname);
				// 	pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
				// 	clength = child.GetComponent<Renderer> ().bounds.size.x;
		
				// 	var position=(plength/2+clength/2)+1/2;
				// 	Transform parentTransform = parent.transform;
				// 	Vector3 parentposition = parentTransform.position;

				// 	child.transform.position+= new Vector3 (parentposition[0],0,0);
				// 	child.transform.position+= new Vector3 (-(position),0,parentposition[2]);
					
		
				
				// }
				// break;

				// case "front":
				// case "infront":

				// x=Int32.Parse(left [0]);
				// lastchar = right[1].TrimEnd().ToCharArray();
				// if(!Char.IsNumber(lastchar[0]))
				// {
				// 	pname=right[1]+"1";
				// }

				// for(int i=0;i<x;i++)
				// {
				// 	string cname=left[1]+(i+1).ToString();
				// 	parent= GameObject.Find (pname);
				// 	child=GameObject.Find (cname);
				// 	pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
				// 	cwidth = child.GetComponent<Renderer> ().bounds.size.z;
				// 	var position=((pwidth/2)+(cwidth/2))*1;
					
				// 	Transform parentTransform = parent.transform;
				// 	Vector3 parentposition = parentTransform.position;

				// 	// child.transform.position+= new Vector3 (0,0,-position);
				// 	child.transform.position+= new Vector3 (parentposition[0],0,parentposition[2]);
				// 	child.transform.position+= new Vector3 (parentposition[0],0,-(position));
		
				
				// }
				// break;


				// case "back":
				// case "behind":

				// x=Int32.Parse(left [0]);
				// lastchar = right[1].TrimEnd().ToCharArray();
				// if(!Char.IsNumber(lastchar[0]))
				// {
				// 	pname=right[1]+"1";
				// }

				// for(int i=0;i<x;i++)
				// {
				// 	string cname=left[1]+(i+1).ToString();
				// 	parent= GameObject.Find (pname);
				// 	child=GameObject.Find (cname);
				// 	pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
				// 	cwidth = child.GetComponent<Renderer> ().bounds.size.z;
				// 	var position=((pwidth/2)+(cwidth/2))*1;
					
				// 	Transform parentTransform = parent.transform;
				// 	Vector3 parentposition = parentTransform.position;

				// 	// child.transform.position+= new Vector3 (0,0,-position);
				// 	child.transform.position+= new Vector3 (parentposition[0],0,parentposition[2]);
				// 	child.transform.position+= new Vector3 (parentposition[0],0,position);
		
				
				// }
				// break;


				


				}

				




    		}
    
				//WORKSPACE
			

			

	
		} 
		} catch (System.NullReferenceException) {

			Debug.Log("model not found");
		}
}
}
