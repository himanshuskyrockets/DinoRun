using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIlls : MonoBehaviour
{

    public int pos;
    public int Loc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.position -= new Vector3(2* Time.deltaTime,0,0);

          if(transform.position.x <= pos){
            
               transform.position = new Vector3(Loc,transform.position.y,0f);
               
          }

    }
}
