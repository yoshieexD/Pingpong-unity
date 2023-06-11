using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenehandler : MonoBehaviour
{
   public  void register()
    {
        SceneManager.LoadScene("scn_register");
    }

public void settings(){
    SceneManager.LoadScene("scn_settings");
}
public void login(){
    SceneManager.LoadScene("scn_login");
}
public void scnloading(){
    SceneManager.LoadScene("scn_loading");
}

}
