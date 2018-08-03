using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadPage : MonoBehaviour
{
    private static bool music = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        float savedAudioValue = PlayerPrefs.GetFloat("Audio", 1);

        AudioListener.volume = savedAudioValue;

      

    }

}