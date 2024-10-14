using UnityEngine;
using Patterns.Singleton;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource musicSource;
    public AudioSource soundEffect;
    public AudioClip musicClip;
    public AudioClip soundEffectClip;

    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void PlaySoundEffect(AudioClip clip)
    {
        soundEffect.clip = clip;
        soundEffect.Play();
    }
}