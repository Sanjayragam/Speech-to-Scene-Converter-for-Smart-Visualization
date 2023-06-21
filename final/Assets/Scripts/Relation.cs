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
int rightbetween;
int frontbetween;
int backbetween;
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

	
		if(parts[count-1]=="1.red" || parts[count-1]=="1.yellow" || parts[count-1]=="1.green" || parts[count-1]=="1.blue" 
		|| parts[count-1]=="1.black" || parts[count-1]=="1.violet")
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

}
}	




public void dimension()
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

		Vector2 pos;

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


		float oheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
		Debug.Log(parts[0]);


		if(parts[0]=="height" && measurevalue[1]=="metre" || measurevalue[1]=="meter")
		{	
			// var scalevalue = Int16.Parse(measurevalue[0]);
			Debug.Log("okieeeeeeeeeeeeeeeeeee");

			// GameObject rotater = GameObject.Find(oname);
			// scale = transform.localScale;


			// scale.y = 2;
			// rotater.transform.localScale = scale;
			// oheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// Debug.Log(oheight);
			// float newheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// GameObject.Find(oname).transform.position = new Vector3(0,newheight / 2,0);
			

			// if(oheight<1){
			// 	float h1=1/oheight;
			// 	Debug.Log(h1);
			// 	scale.y = h1*scalevalue;
			// 	rotater.transform.localScale = scale;
			// 	oheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// 	Debug.Log(oheight);
			// 	float newheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// 	GameObject.Find(oname).transform.position = new Vector3(0,newheight / 2,0);
			// }

			// if(oheight>1){
			// 	float h1=2/oheight;
			// 	Debug.Log(h1);
			// 	float newscalevalue= scalevalue-2;
			// 	scale.y = h1*newscalevalue;
			// 	rotater.transform.localScale = scale;
			// 	oheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// 	Debug.Log(oheight);
			// 	float newheight = GameObject.Find(oname).GetComponent < Renderer > ().bounds.size.y;
			// 	GameObject.Find(oname).transform.position = new Vector3(0,newheight / 2,0);
			// }

		}

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
					color();
					break;



				case "front":
				case "infront":


					string[] measurefront = parts [1].Split(".");
					Debug.Log(measurefront[1]);
					if(measurefront[1]=="front" && Int32.Parse(measurefront[0])>1){
						frontbetween = Int32.Parse(measurefront[0]);
					}
					else if(measurefront[1]=="infront" && Int32.Parse(measurefront[0])>1){
						frontbetween = Int32.Parse(measurefront[0]);
					}

					else{
						frontbetween = 0;
					}	


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
					var position=((pwidth/2)+(cwidth/2))+frontbetween;
					
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					// child.transform.position+= new Vector3 (0,0,0);
					child.transform.position+= new Vector3 (0,0,parentposition[2]);
					child.transform.position+= new Vector3 (parentposition[0],0,-(position));
			
					childss.Add(child);


					}
					color();
					break;






					case "back":
					case "behind":


					string[] measureback = parts [1].Split(".");
					Debug.Log(measureback[1]);
					if(measureback[1]=="back" && Int32.Parse(measureback[0])>1){
						backbetween = Int32.Parse(measureback[0]);
					}
					else if(measureback[1]=="behind" && Int32.Parse(measureback[0])>1){
						backbetween = Int32.Parse(measureback[0]);
					}

					else{
						backbetween = 0;
					}	


				
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
					var position=((pwidth/2)+(cwidth/2))+backbetween;
					
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (0,0,parentposition[2]);
					child.transform.position+= new Vector3 (parentposition[0],0,position);
				
					childsss.Add(child);


					}
					color();
					break;




					case "left":
					case "left side":


					string[] measureleft = parts [1].Split(".");
					Debug.Log(measureleft[1]);
					if(measureleft[1]=="left" && Int32.Parse(measureleft[0])>1){
						leftbetween = Int32.Parse(measureleft[0]);
						Debug.Log(leftbetween);
					}
					else{
						leftbetween = 0;
						Debug.Log(leftbetween);
					}	


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
		
					// var position=(plength/2+clength/2)+1/2;
					var position=(plength/2+clength/2)+leftbetween;
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (parentposition[0],0,0);
					child.transform.position+= new Vector3 (position,0,parentposition[2]);

				
					childsl.Add(child);


					}
					color();
					break;



					case "right":
					case "right side":

					Debug.Log(partss[1]);
					string[] measureright = parts [1].Split(".");
					Debug.Log(measureright[1]);
					if(measureright[1]=="right" && Int32.Parse(measureright[0])>1){
						rightbetween = Int32.Parse(measureright[0]);
					}
					else{
						rightbetween = 0;
					}	



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

					var position=(plength/2+clength/2)+rightbetween;
					Transform parentTransform = parent.transform;
					Vector3 parentposition = parentTransform.position;

					child.transform.position+= new Vector3 (parentposition[0],0,0);
					child.transform.position+= new Vector3 (-(position),0,parentposition[2]);

				
					childsr.Add(child);


					}
					color();
					break;


				}

			

    		}
    
				//WORKSPACE
			

			

	
		} 
		} catch (System.NullReferenceException) {

			Debug.Log("model not found");
		}
}
}
