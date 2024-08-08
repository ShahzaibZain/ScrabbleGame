using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonFE : MonoBehaviour
{
   public void goback()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void gotomenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
