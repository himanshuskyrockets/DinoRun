using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryHelper : MonoBehaviour
{
    public void Retry(){

         SceneManager.LoadScene("Game");
    }
}
