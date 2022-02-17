using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public GameObject top;
    Vector3 AradakiMesafe;
   
    void Start()
    {
        AradakiMesafe = transform.position - top.transform.position;
    }

    
    void LateUpdate() 
    {
        transform.position = top.transform.position + AradakiMesafe;
    }
}
