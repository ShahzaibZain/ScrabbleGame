using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Get the VideoPlayer component attached to this GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        // Add a listener for the loopPointReached event
        videoPlayer.loopPointReached += EndReached;
    }
   

    void EndReached(VideoPlayer vp)
    {
        // Remove or disable the GameObject with the VideoPlayer component
        gameObject.SetActive(false);
        // or Destroy(gameObject);
    }
}
