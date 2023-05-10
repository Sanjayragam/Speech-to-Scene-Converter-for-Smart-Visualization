using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Showname : MonoBehaviour
{
    public InputField field;
    void Awake()
    {
        string filetext = @"C:\Main Project\main\final\name.txt";
        string[] lines = File.ReadAllLines(filetext);
	    field.text =lines[0];
        Debug.Log(lines[0]);
        Debug.Log("helloo");

    }
}

