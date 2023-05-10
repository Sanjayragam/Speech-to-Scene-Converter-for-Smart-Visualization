using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class hello : MonoBehaviour
{
     public void Awake()
    {

        // SceneManager.LoadScene(scenename);
        string filetext = @"C:\Main Project\main\final\test.txt";

        string[] lines = File.ReadAllLines(filetext);

        
        
        
        int len =  lines.Length;
        for (int i = 0; i < len; i++) 
        {
            int size = 50;
            string[] cars = new string[size];
            // Debug.Log(lines[i]);
            cars[i] = lines[i];
            var model = cars[i].ToString();
            GameObject instance = Instantiate(Resources.Load(cars[i], typeof(GameObject))) as GameObject;

           

          
        }

         
        

    }

}
