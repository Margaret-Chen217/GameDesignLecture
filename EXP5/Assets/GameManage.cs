using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManage : MonoBehaviour
{
  
    public Slider mainslider;
    public void StartGame(){
        SceneManager.LoadScene("MainScene");
    }

    public void ReturnHome(){
        SceneManager.LoadScene("SampleScene");
    }

    
    
}

