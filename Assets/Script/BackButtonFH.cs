using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonFH : MonoBehaviour
{
    public void goback()
    {
    SceneManager.LoadSceneAsync(1);
    }
}
