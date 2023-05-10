using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
public class Generate: MonoBehaviour {

  GameObject instance;
  public test ts;
  public void gen() {

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


      string[] pipe = new string[count];
    
      for (int j = 0; j <count; j++) 
		  {
  		  pipe[j]=sent[j];
		  }

      foreach (string part in pipe) {
        // Debug.Log(part);	
      }


      foreach(string item in pipe) {
      if (item != ".") {
        try {

          string[] items = item.Split('.');
          int x = Int32.Parse(items[0]);
          // Debug.Log(x);
          
          //GENERATE SPACE
          string a = items[1] + (1).ToString();
          Vector2 pos;
          for (int i = 0; i < x; i++) {

            string name = items[1] + (i + 1).ToString();

            if (!GameObject.Find(name)) {

              instance = Instantiate(Resources.Load(items[1], typeof (GameObject))) as GameObject;
              instance.transform.GetChild(0).name = name;

              // Debug.Log(name);
              float height = GameObject.Find(name).GetComponent < Renderer > ().bounds.size.y;
              float width = GameObject.Find(name).GetComponent < Renderer > ().bounds.size.x;
              pos = ts.getpoint(i + 1, width + width / 5);
              // Debug.Log(pos);
              GameObject.Find(name).transform.position = new Vector3(pos.x, height / 2, pos.y);

            } else {

            }

          }
          //GENERATE SPACE

        } catch (System.Exception) {

			    // Debug.Log("hai");
		    }


      }
    }
    
    }

    // string fileName = @"C:/Main Project/main/final/promptformatted.txt";
    // string text = File.ReadAllText(fileName);
    // var count=-1;
    // string[] lines = text.Split(Environment.NewLine);
    // foreach (string line in lines) {
    //     count=count+1;
    //     // Debug.Log(line);
    // }
    
    // string[] pipe = new string[count];
    
    // for (int i = 0; i <count; i++) 
		// {
  	// 	pipe[i]=lines[i];
		// }

    // foreach (string part in pipe) {
    //   Debug.Log(part);	
    // }
			


   
    
  }
}