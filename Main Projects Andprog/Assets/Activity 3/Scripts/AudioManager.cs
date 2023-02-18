using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioClip[] audioClip;
    public AudioSource audioSource;
    public AudioSource audioSource2;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

  
}
