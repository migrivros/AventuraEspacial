using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndMenu : MonoBehaviour
{
    [SerializeField] private AudioSource endSoundEffect;

    public void Quit()
    {
        endSoundEffect.Play();
        Application.Quit();
    }
}
