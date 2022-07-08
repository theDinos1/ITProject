using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioManager : MonoBehaviour
{
    public VideoPlayer video;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("musicVolume"));
        video.SetDirectAudioVolume(0,PlayerPrefs.GetFloat("musicVolume"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
