using UnityEngine;
using System.Collections;
using System.IO;
using System.Diagnostics;

public class Inputscript : MonoBehaviour {

	public string myString;
	
	// Use this for initialization
	public void callinputpy () {

		string python = @"C:/Program Files/Python37/python.exe" ;
		string myPythonApp = @"C:/sample.py";

	
		

		// Create new process start info
		ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);
		//myProcessStartInfo.CreateNoWindow=true;
		myProcessStartInfo.CreateNoWindow=true;
		// make sure we can read the output from stdout
		myProcessStartInfo.UseShellExecute = false;
		myProcessStartInfo.RedirectStandardOutput = true;

		// start python app with 3 arguments 
		// 1st arguments is pointer to itself, 2nd and 3rd are actual arguments we want to send
		myProcessStartInfo.Arguments = myPythonApp;

		Process myProcess = new Process();
		// assign start information to the process
		myProcess.StartInfo = myProcessStartInfo;


		myProcess.Start();


		myProcess.WaitForExit();
		myProcess.Close();
	
	}
	

}
