using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cac : MonoBehaviour
{
    public GameObject gameOverUI;
     public  AudioSource Deadaudio;
//    public Score other;
    // Start is called before the first frame update
   public void Start()
    {
    //    other.Start();
    }

    // Update is called once per frame
  public void Update()
    {  
        transform.position -= new Vector3(9 * Time.deltaTime,0,0);
        
        //  if( scoreAmount >= 50){
        //      transform.position -= new Vector3(15 * Time.deltaTime,0,0);

        //  }
    }
   void OnCollisionEnter2D(Collision2D col) {
      
        if(col.gameObject.tag == "Player"){
            Deadaudio.Play();
            Time.timeScale = 0;
        }


  }
 
//   public void Script(){

//       other.scoreAmount();
//   }






}//Class
