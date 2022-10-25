using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class script_hasil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 Screen.orientation = ScreenOrientation.LandscapeLeft;
            string hasil= GlobalVariables.Get<string>("hasil");
            string judul= GlobalVariables.Get<string>("judul");
            int score= GlobalVariables.Get<int>("score");

            Debug.Log("score "+score.ToString()+"#"+hasil+"#"+judul); 

            GameObject.Find("txtjudul").GetComponentInChildren<Text>().text =judul;
            GameObject.Find("txtscore").GetComponentInChildren<Text>().text =score.ToString();
            GameObject.Find("txthasil").GetComponentInChildren<Text>().text =hasil;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      public void Buka(string al){
        //Application.LoadLevel (al);
        SceneManager.LoadScene(al);
    }
}
