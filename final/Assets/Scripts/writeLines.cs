using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
 

public class writeLines : MonoBehaviour
{
    public void writelines()
    {

        string fileName = @"C:/Main Project/main/final/promptformatted.txt";
 
        string text = File.ReadAllText(fileName);
        var count=-1;
        string[] lines = text.Split(Environment.NewLine);
        foreach (string line in lines) {
            count=count+1;
        }
    
        // string[] parts = new string[count-1];
        string[] parts = new string[count];
        // string[] parts = new string[3] {"Volvo", "BMW", "Ford"};

        for (int i = 0; i <count; i++) 
		{
  			parts[i]=lines[i];
		}

        foreach (string part in parts) {
            Debug.Log(part);
        }
    }
}





			

	

