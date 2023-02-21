using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuEvents : MonoBehaviour
{

    public Slider volumeSlider;
    public Slider volumeSliderSFX;
    public AudioMixer mixer;
    public AudioMixer mixerSFX;
    private float value;
    private float valueSFX;


    private void Start()
    {
        Time.timeScale = 1;
        volumeSlider.value = PlayerPrefs.GetFloat("volume", value);
        volumeSliderSFX.value = PlayerPrefs.GetFloat("volumeSFX", valueSFX);
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void SetVolume()
    {
        
        mixer.SetFloat("volume", volumeSlider.value);
        mixer.GetFloat("volume", out value);
        PlayerPrefs.SetFloat("volume", value);
  
    }

    public void SetVolumeSFX()
    {

        mixerSFX.SetFloat("volumeSFX", volumeSliderSFX.value);
        mixerSFX.GetFloat("volumeSFX", out valueSFX);
        PlayerPrefs.SetFloat("volumeSFX", valueSFX);
        
    }
    
}
