using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager3 : MonoBehaviour
{
    public GameObject audioManager;

    public AudioClip fight;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = audioManager.GetComponent<AudioSource>();
        audioSource.clip = fight;
        audioSource.Play();
    }
}

