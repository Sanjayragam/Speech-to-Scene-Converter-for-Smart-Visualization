using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class InputSentence : MonoBehaviour
{
    
    public string sentence;
    public Inputscript ip;
    public GameObject inputField;
    public GameObject inputField2;

    public void Input()
    {
        sentence = inputField.GetComponent<Text>().text;
        sentence = inputField2.GetComponent<Text>().text;

        using (StreamWriter writer = new StreamWriter(@"C:\Main Project\main\final\sentence.txt"))
        {
            writer.WriteLine(sentence);
        }

		ip.callinputpy ();
		
    
    }
}


