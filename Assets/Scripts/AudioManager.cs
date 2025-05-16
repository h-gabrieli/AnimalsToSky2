using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip backgroundMusic;
    public AudioClip keyPickupSound;
    public AudioClip damageSound; 

    private void Awake()
    {
        // Singleton para garantir uma instância global
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic(backgroundMusic);
    }

    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip sfx)
    {
        sfxSource.PlayOneShot(sfx);
    }
    public void PlayKeyPickup()
    {
    PlaySFX(keyPickupSound);
    }
}
