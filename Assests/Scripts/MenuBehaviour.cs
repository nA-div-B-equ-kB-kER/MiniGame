using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    
    public void triggerMenuBehav(bool i){
        if(i){
            Application.Quit();
        }
        else{
            SceneManager.LoadScene("MiniGame1");
        }
    }
    
}
