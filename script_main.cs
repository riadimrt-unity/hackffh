using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script_main : MonoBehaviour
{

    public void Buka(string al){
        //Application.LoadLevel (al);
        SceneManager.LoadScene(al);
    }

    public void Buka1(string al){
        SceneManager.LoadScene(al);
        GlobalVariables.Set("page", "ar1");
    }
    public void Buka2(string al){
        SceneManager.LoadScene(al);
        GlobalVariables.Set("page", "ar2");
    }
    public void Buka3(string al){
        SceneManager.LoadScene(al);
        GlobalVariables.Set("page", "ar3");
    }
    public void Buka4(string al){
        SceneManager.LoadScene(al);
        GlobalVariables.Set("page", "ar4");
    }
    public void Buka5(string al){
        SceneManager.LoadScene(al);
        GlobalVariables.Set("page", "ar5");
    }

    public void Keluar(){
        Application.Quit();
    }

    public void SendMail(string al){
        Application.OpenURL("mailto:"+al);
    }
  public void BukaLink(string al){
        Application.OpenURL(al);
    }

    void Start()
    {
         Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//public GameObject c_awal,c_exit,c_info,c_help,c_profil;

//      public void OpenCanvas(string al){
//         if(al=="aexit"){
//             c_awal.SetActive(false);
//             c_exit.SetActive(true);
//         }   
//         else if(al=="exita"){
//             c_awal.SetActive(true);
//             c_exit.SetActive(false);
//         }


//         else  if(al=="ainfo"){
//             c_awal.SetActive(false);
//             c_info.SetActive(true);
//         }   
//         else if(al=="infoa"){
//             c_awal.SetActive(true);
//             c_info.SetActive(false);
//         }


//         else if(al=="ahelp"){
//             c_awal.SetActive(false);
//             c_help.SetActive(true);
//         }
//         else if(al=="helpa"){
//             c_awal.SetActive(true);
//             c_help.SetActive(false);
//         }


//         else if(al=="aprofil"){
//             c_awal.SetActive(false);
//             c_profil.SetActive(true);
//         }
//         else if(al=="profila"){
//             c_awal.SetActive(true);
//             c_profil.SetActive(false);
//         }

//      }

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFocus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += StartVuforiaFocus;
    }

    public void StartVuforiaFocus()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

*/

