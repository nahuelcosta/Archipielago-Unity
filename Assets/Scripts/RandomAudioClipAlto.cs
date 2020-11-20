using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAudioClipAlto: MonoBehaviour {
    
    public AudioClip[] clips1; // Set de clips n°1
    public AudioClip[] clips2; // set de clips n°2
    public AudioSource audioSource;
    Coroutine currentCoroutine = null;


    IEnumerator random1()
    {
        yield return new WaitForSeconds(35.0f);
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
        currentCoroutine = StartCoroutine(random2());
    }

    IEnumerator random2()
    {
        while(true)
        {
        audioSource.clip = clips2[Random.Range(0,clips2.Length)];
        audioSource.Play();
        yield return new WaitForSeconds(2.0f);
        }
    }

    IEnumerator StopClip2(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        StopCoroutine(currentCoroutine);
    }

    void Start()
    {
       currentCoroutine = StartCoroutine(random1());
       StartCoroutine(StopClip1(50.0f));
       StartCoroutine(StopClip2(65.0f));

    }

     void Update(){
        
    }
    
}    
