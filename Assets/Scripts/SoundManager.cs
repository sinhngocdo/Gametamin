using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip hoverClip;
    [SerializeField]
    private AudioClip clickClip;

    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverClip);
    }

    public void ClickSound()
    {
        audioSource.PlayOneShot(clickClip);
    }
}
