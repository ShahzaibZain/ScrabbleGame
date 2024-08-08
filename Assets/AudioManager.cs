using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    AudioSource music;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void OnMusic()
    {
        music.Play();
    }
    public void OffMusic()
    {
        music.Stop();
    }

}