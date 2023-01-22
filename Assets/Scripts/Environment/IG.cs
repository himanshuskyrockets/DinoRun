using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG : MonoBehaviour
{
  
  public GameObject spawn;
    public GameObject spawn1;
  public GameObject Cac;
  public GameObject Cac2;
 public float side;
 public float height;
 



    void Start()
    {
     
       InvokeRepeating ("a",1,2.5f); 
   
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void a(){



  //  spawn = Instantiate (Cac,transform.position,Quaternion.identity) as GameObject;
          GameObject spawn1 = Instantiate(Cac2) as GameObject;
         spawn1.transform.position = transform.position + new Vector3(Random.Range(1.5f,side),Random.Range(-5.3f,height),0) ;
         spawn1.transform.localScale += new Vector3(Random.Range(0.29f,0.1f),Random.Range(0.28f,0.1f),0);


       spawn = Instantiate (Cac,transform.position,Quaternion.identity) as GameObject;

         Destroy(spawn,5);
       Destroy(spawn1,5);
        
 

    }

 

}
