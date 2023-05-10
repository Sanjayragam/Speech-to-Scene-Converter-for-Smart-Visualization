using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadObject : MonoBehaviour
{
   
    // public string scenename = "scene 2";
    // public test ts;
    
    public void Loadmodel()
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
            // float height =GameObject.Find (cars[i]).GetComponent<Renderer> ().bounds.size.y;

            // Debug.Log(height);
            // float width =GameObject.Find (name).GetComponent<Renderer> ().bounds.size.x;
			// // pos=ts.getpoint(i+1,width+width/5);
            // GameObject.Find (cars[i]).transform.position=new Vector3(0,height/2,0);

           

          
        }

         
        

    }

    

}