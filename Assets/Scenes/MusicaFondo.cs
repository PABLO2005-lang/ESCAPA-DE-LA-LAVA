
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.volume = 0.3f;

        audioSource.Play();
    }
}
