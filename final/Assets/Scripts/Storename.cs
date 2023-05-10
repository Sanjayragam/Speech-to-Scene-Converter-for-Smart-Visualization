using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Storename : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
   
  
    public void StoreName()
    {
      theName = inputField.GetComponent<Text>().text;

      using (StreamWriter writer = new StreamWriter(@"C:\Main Project\main\final\name.txt"))
      {
          writer.WriteLine(theName);
      }
    
    }
}

