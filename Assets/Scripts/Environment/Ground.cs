using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
     public int pos;
    public int Loc;
  
    
    void Update()
    {
        
          transform.position -= new Vector3(2* Time.deltaTime,0,0);

          if(transform.position.x <= pos){
               transform.position = new Vector3(Loc * Time.deltaTime,transform.position.y,0f);
               
          }
    }

}//class
