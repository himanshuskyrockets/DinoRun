using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{ 
    public float xz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
          transform.position -= new Vector3(6 * Time.deltaTime,0,0);

          if(transform.position.x <= -17.5){
            
               transform.position = new Vector3(xz,transform.position.y,0f);
               
          }
    }
    
}//class
