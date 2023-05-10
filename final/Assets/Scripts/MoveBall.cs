using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MoveBall : MonoBehaviour
{

    GameObject pentas;
    public string mname;
    
    public void move()
    {
        mname="penta";
        pentas= GameObject.Find (mname);
        pentas.transform.position+= new Vector3 (0,0,20);

    }
}
