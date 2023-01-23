using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryHelper : MonoBehaviour
{
    public void LoadScene(){

         SceneManager.LoadScene("Game");
    }
    public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
    }
    
}//class
