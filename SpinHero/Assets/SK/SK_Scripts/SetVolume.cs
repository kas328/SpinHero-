using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    GameObject musicManager;
    AudioSource audioSource;
    Slider slider;

    private void Start()
    {
        musicManager = GameObject.Find("BackgroundMusic");
        audioSource = musicManager.GetComponent<AudioSource>();
        slider = GetComponent<Slider>();
    }

    public void SetAudio()
    {
        audioSource.volume = slider.value;
    }
}
