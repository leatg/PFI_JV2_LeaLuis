using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip walkingSound;
    public AudioClip attackedSound;
    public AudioClip breathingSound;
    public AudioClip runningSound;

    public bool IsWalking { get; set; }
    public bool IsAttacked { get; set; }
    public bool IsRunning { get; set; }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (IsWalking)
        {
            PlaySound(walkingSound);
        }
        else if (IsAttacked)
        {
            PlaySound(attackedSound);
        }
        else if (IsRunning)
        {
            PlaySound(breathingSound);
            PlaySound(runningSound);
        }
    }

    void PlaySound(AudioClip clip)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }

    public void StopSound()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}