using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musice : MonoBehaviour
{
    private static bool music = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        float savedAudioValue = PlayerPrefs.GetFloat("Audio", 1);

        AudioListener.volume = savedAudioValue;

        if (music)
            Destroy(this.gameObject);
        if (!music)
        {

            DontDestroyOnLoad(this.gameObject);

            music = true;
        }


    }

}