using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioClipSoprano: MonoBehaviour {
    
    public AudioClip[] clips1; // Set de clips n°1
    public AudioSource audioSource;
    Coroutine currentCoroutine = null;


    IEnumerator random1()
    {
        yield return new WaitForSeconds(50.0f);
        while(true)
        {
        audioSource.clip = clips1[Random.Range(0,clips1.Length)];
        audioSource.Play();
        yield return new WaitForSeconds(3.0f);
        }
    }

    IEnumerator StopClip1(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        StopCoroutine(currentCoroutine);
    }

    void Start()
    {
       currentCoroutine = StartCoroutine(random1());
       StartCoroutine(StopClip1(65.0f));

    }

     void Update(){
        
    }
    
}    
