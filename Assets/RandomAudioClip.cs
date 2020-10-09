using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioClip: MonoBehaviour {
    
    public AudioClip[] clips;
    public AudioSource audioSource;

    void Start (){
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
    }
    public AudioClip GetRandomClip()
    {
        return clips[Random.Range(0,clips.Length)];
    }
    void Update (){
        if (!audioSource.isPlaying)
        {
            audioSource.clip=GetRandomClip();
            audioSource.Play();
        }
    }
}