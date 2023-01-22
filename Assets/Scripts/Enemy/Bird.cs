using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{


public GameObject gameOverUI;





void Start()
{
  
}


void Update()
{
        // transform.position  -= new Vector3(Random.Range(10 * Time.deltaTime , 0), Random.Range(1 * Time.deltaTime, 0f), 0f);

        transform.position -= new Vector3(10 * Time.deltaTime,0,0);
            // if()
          
           if(transform.position.x <= -24){
            
               transform.position = new Vector3(48,transform.position.y,0f);
               
          }



}



// public void OnCollisionEnter2D(Collision2D Col) {
    
//     if(Col.gameObject.tag == "Player"){

//             gameOverUI.SetActive (true);
//             Time.timeScale = 0;

//     }


// }



















    
}//Class
