using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonFM : MonoBehaviour

{
    public void goback()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
