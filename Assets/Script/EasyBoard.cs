using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyBoard : MonoBehaviour
{
  public void Easy()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Medium()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void Hard()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void goback()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
