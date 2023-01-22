using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
  
    public bool isJuming;
       
      public GameObject gameOverUI;
       public  AudioSource Jumpaudio;


    // public Animator anim;

    void Start()
    {  

          gameOverUI.SetActive (false); //Restart Ui
         Time.timeScale = 1;
    
   
         isJuming = false;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isJuming == false){
          
      GetComponent<Rigidbody2D> (). velocity = new Vector3(0,16,0);  
      
        isJuming = true;
       Jumpaudio.Play();  
        // anim.Play("Dino_Jump_anim");
        }
       

    }

 void OnCollisionEnter2D(Collision2D col) {

     if(col.gameObject.tag == "Finish"){

         isJuming = false;
         
     }
     if(col.gameObject.tag == "Respawn"){
           
           gameOverUI.SetActive (true);
             Time.timeScale = 0;

     }
     
 }






}
