using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDespairCutsceneManager : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip stoneSlide;
    [SerializeField] private AudioClip footsteps;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayStoneSlide()
    {
        audioSource.PlayOneShot(stoneSlide);
    }

    private void PlayFootsteps()
    {
        audioSource.PlayOneShot(footsteps);
    }
}
