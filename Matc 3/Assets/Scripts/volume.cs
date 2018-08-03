using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class volume : MonoBehaviour {
    public Slider slider;
    public Text valuCount;

    private void Start()
    {
        float savedAudioValue = PlayerPrefs.GetFloat("Audio", 1);
        slider.value = savedAudioValue;
        valuCount.text = slider.value.ToString();
    }

    public void OnChange()
    {
        valuCount.text = slider.value.ToString();
        AudioListener.volume = slider.value;
        PlayerPrefs.SetFloat("Audio", slider.value);
    }
}
   


