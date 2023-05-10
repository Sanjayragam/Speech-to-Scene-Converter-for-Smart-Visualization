using UnityEngine;
using System.Collections;
using System.IO;
using System.Diagnostics;

public class FormatPrompt : MonoBehaviour {


	public void formatinput() {

		string python = @"C:/Program Files/Python37/python.exe" ;
		string myPythonApp = @"C:/formatprompt.py";

	
		

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

		// Read the standard output of the app we called. 
		// in order to avoid deadlock we will read output first and then wait for process terminate:
		// StreamReader myStreamReader = myProcess.StandardOutput;
		// myString = myStreamReader.ReadToEnd();

		/*if you need to read multiple lines, you might use:
                string myString = myStreamReader.ReadToEnd() */          

		// wait exit signal from the app we called and then close it.
		myProcess.WaitForExit();
		myProcess.Close();
	
	}
	

}
