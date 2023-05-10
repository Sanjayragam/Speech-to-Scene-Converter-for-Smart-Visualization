using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

public class UDPReceive : MonoBehaviour
{

    Thread receiveThread;
    UdpClient client; 
    GameObject penta;
    public string mname;
    public int port = 5052;
    public bool startRecieving = true;
    public bool printToConsole = false;
    public string data;
    public float x;


    public void Start()
    {

        receiveThread = new Thread(new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();
        
        mname="penta";
        penta= GameObject.Find (mname);
        penta.transform.position+= new Vector3 (0,0,8);

        

        
    }


    // receive thread
    public void ReceiveData()
    {

        client = new UdpClient(port);
        while (startRecieving)
        {

            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                x = Int32.Parse(data);
                Debug.Log(x);
                Vector3 temp = new Vector3(7.0f,0,0);

                
                // using (StreamWriter writer = new StreamWriter(@"C:\Main Project\main\final\name.txt"))
                // {
                //     writer.WriteLine(x);
                // }

                // string sent_count = @"C:/Main Project/main/final/name.txt";
	            // string text_count = File.ReadAllText(sent_count);
                // Debug.Log(text_count);
                // if (printToConsole) { print(data); }
            }
            catch (Exception err)
            {
                print(err.ToString());
            }
        }

        
    }

    // public void move()
    // {
    //     mname="penta";
    //     penta= GameObject.Find (mname);
    //     penta.transform.position+= new Vector3 (0,0,8);

    // }
   



}
