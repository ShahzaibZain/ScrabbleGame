using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAudio : MonoBehaviour
{
    [SerializeField]
    AudioSource music;

    public void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        StartCoroutine(DelayStartMusic());
    }

    private IEnumerator DelayStartMusic()
    {
        music.Stop();
        yield return new WaitForSeconds(5); // Delay for 5 seconds
        music.Play();
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
