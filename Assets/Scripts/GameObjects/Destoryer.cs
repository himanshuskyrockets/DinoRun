using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryer : MonoBehaviour
{



void OnCollisionEnter2D(Collision2D Col)
{
    if(Col.gameObject.tag == "Respawn")
    {
        Destroy(Col.gameObject);
    }
  
}







}//class
