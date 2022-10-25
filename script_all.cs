using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class script_all : MonoBehaviour
{
    public void Buka(string al){
       //Application.LoadLevel (al);
        SceneManager.LoadScene(al);
    }
    public void Keluar(){
        Application.Quit();
    }
    public void Link(string url){
        Application.OpenURL(url);
    }


    void Start()
    {
       Screen.orientation = ScreenOrientation.LandscapeLeft;  
       GlobalVariables.Set("page", "");
    }

    void Update()
    {
        
    }
}
