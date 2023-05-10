using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Collections.Generic;
public class Color : MonoBehaviour {

GameObject parent;
string pname;
public void Colorobject()
{

	
	string sent_count = @"C:/Main Project/main/final/count.txt";
    string text_count = File.ReadAllText(sent_count);
    var sentences=Int16.Parse(text_count);
    for (int k = 1; k <=sentences; k++) 
    {
      string Path="C:/Main Project/main/final/promptformatted"+k+".txt";
      // Debug.Log(Path);
      string sentence_file = File.ReadAllText(Path);
      var count=-1;
      string[] sent = sentence_file.Split(Environment.NewLine);
      foreach (string sent_line in sent)
	  {
        count=count+1;
        Debug.Log(sent_line);
        
      }
	}

	string[] parts = new string[4];

    parts[0]="1.color";
    parts[1]="1.of";
    parts[2]="penta1";
    parts[3]="red";
    // parts[3]="red";


    pname=parts[2];
    parent= GameObject.Find (pname);

    
    Material newMat = Resources.Load(parts[3], typeof(Material)) as Material;
    // newMat.SetColor("_Color", newColor);
	parent.GetComponent<Renderer>().material = newMat;


}
}
		