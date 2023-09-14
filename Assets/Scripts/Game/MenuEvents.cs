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

    public Button level1, level2, level3, level4, level5, level6, level7, level8, level9;
    public static int levelPassed;


    private void Start()
    {
        Time.timeScale = 1;
        volumeSlider.value = PlayerPrefs.GetFloat("volume", value);
        volumeSliderSFX.value = PlayerPrefs.GetFloat("volumeSFX", valueSFX);

        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        level6.interactable = false;
        level7.interactable = false;
        level8.interactable = false;
        level9.interactable = false;

        switch (levelPassed)
        {
            case 1:
                level2.interactable = true;
                break;
            case 2:
                level2.interactable = true;
                level3.interactable = true;
                break;
            case 3:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                break;
            case 4:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                break;
            case 5:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                break;
            case 6:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                break;
            case 7:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                break;
            case 8:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = true;
                level5.interactable = true;
                level6.interactable = true;
                level7.interactable = true;
                level8.interactable = true;
                level9.interactable = true;
                break;
        }
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

    public void resetPlayerPrefs()
    {
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        level6.interactable = false;
        level7.interactable = false;
        level8.interactable = false;
        level9.interactable = false;

        PlayerPrefs.DeleteAll();
    }
    
}
