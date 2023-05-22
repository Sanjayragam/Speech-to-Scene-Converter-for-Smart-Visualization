using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowPrompt : MonoBehaviour
{
    // public string theName;
    // public GameObject inputField;
    public InputField field;
   
  
    public void StoreName()
    {
  
      string filetext = @"C:\Main Project\main\final\sentence.txt";
      string[] lines = File.ReadAllLines(filetext);
		  field.text =lines[0];
      Debug.Log(lines[0]);
   
    }
}
