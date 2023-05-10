using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
public class Relation : MonoBehaviour {

float pheight;
float pwidth;
float plenghth;
float cheight;
float cwidth;
float clenghth;

GameObject parent;
GameObject child;
string pname;
char[] lastchar;
public string colorvar;



public void color()
{

	string sent_count = @"C:/Main Project/main/final/count.txt";
	string text_count = File.ReadAllText(sent_count);
	var sentences = Int16.Parse(text_count);
	// Debug.Log(sentences);
	for (int k = 1; k <= sentences; k++) {
  		string Path = "C:/Main Project/main/final/promptformatted" + k + ".txt";
  		Debug.Log(Path);
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
			Debug.Log(j+"-"+parts[j]);
			colorvar=parts[j];
  		}

  		string[] left = parts[0].Split('.');
  		string[] right = parts[2].Split('.');

		Debug.Log(colorvar);
		switch (parts [2]) {

				case "1.on":


					Debug.Log("inside color function");
					break;
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

		
				
				switch (parts [1]) {

				case "1.on":


					List<GameObject> childs = new List<GameObject>();
					int x=Int32.Parse(left [0]);
					lastchar = right[1].TrimEnd().ToCharArray();

					if(!Char.IsNumber(lastchar[0]))
					{
						pname=right[1]+"1";
					}

					for(int i=0;i<x;i++)
					{
					// Debug.Log(pname);
					string cname=left[1]+(i+1).ToString();
					parent= GameObject.Find (pname);
					child=GameObject.Find (cname);
					
					pheight = parent.GetComponent<Renderer> ().bounds.size.y;

					
					// pwidth = parent.GetComponent<Renderer> ().bounds.size.z;

					// Debug.Log(pname);
					// Debug.Log(cname);
					// Debug.Log(pwidth);

					// StreamWriter sw = new StreamWriter("C:/Main Project/main/final/pwidth.txt");
    				// sw.WriteLine(pwidth);
   					// sw.Close();
				
					// var px = parent.GetComponent<Renderer> ().bounds.size.x;
					// Debug.Log(px);
					// var pz = parent.GetComponent<Renderer> ().bounds.size.z;
					// Debug.Log(pz);


					cheight = child.GetComponent<Renderer> ().bounds.size.y;
					child.transform.position+= new Vector3 (0,pheight,0);
					childs.Add(child);

					// Debug.Log(pname);
					// Material newMat = Resources.Load("yellow", typeof(Material)) as Material;
					// child.GetComponent<Renderer>().material = newMat;


					}
					break;


					case "1.near":

				//NUMBER Debug.Log (right [0]);
				//ITEM Debug.Log (right [1]);
				// tolerance=0;
				x=Int32.Parse(left [0]);

				lastchar = right[1].TrimEnd().ToCharArray();

				if(!Char.IsNumber(lastchar[0]))
				{
					pname=right[1]+"1";
				}

				for(int i=0;i<x;i++)
				{
					string cname=left[1]+(i+1).ToString();
					parent= GameObject.Find (pname);
					child=GameObject.Find (cname);

					pwidth = parent.GetComponent<Renderer> ().bounds.size.z;
					cwidth = child.GetComponent<Renderer> ().bounds.size.z;

					// Debug.Log(pname);
					// Debug.Log(cname);
					// Debug.Log(pwidth+cwidth);


					// StreamWriter sw = new StreamWriter("C:/Main Project/main/final/pwidth.txt");
    				// sw.WriteLine(pwidth+cwidth);
   					// sw.Close();

					var position=(pwidth+cwidth)*1;
					child.transform.position+= new Vector3 (position,0,0);
					// child.transform.position+= new Vector3 (0,0,5);
				
				}
				break;


				


				
				}



				



    		}
    


    		// foreach (string line in lines) {
            // 	counts=counts+1;
			// 	if(line=="1.yellow" || line=="1.red");
			// 	{
			// 		color=line;
			// 	}
				

        	// }

			// Debug.Log(color);
    
        	



			
			
	

				
				

				
				//WORKSPACE
		

	
		} 
		} catch (System.NullReferenceException) {

			Debug.Log("one of the model not found");
		}
}
}
