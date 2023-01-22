using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   
   public Text scoreText;
   public float scoreAmount;
   public float PIPS;


   public void Start()
    {
         scoreAmount = 0f;
         PIPS = 5f;
         Time.timeScale = 1;
    }

    // Update is called once per frame
   public void Update()
    {
        
      scoreText.text = "000" + (int)scoreAmount ;
      scoreAmount += PIPS * Time.deltaTime;

      // if(scoreAmount >=50){ // To Increase Speed but Game Is not Pausing

      //   Time.timeScale = 2;
      // }

    }

   void OnCollisionEnter2D(Collision2D Col) {
     
   if(Col.gameObject.tag == "Player"){

    
   Time.timeScale = 0; 
   }

 

   }



}

