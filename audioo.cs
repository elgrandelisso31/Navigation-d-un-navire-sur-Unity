using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioo : MonoBehaviour
{
    public AudioClip son;
    bool isPlaying = true;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
{
    source = GetComponent<AudioSource>();
}

// Update is called once per frame
void Update()
{
     if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        isPlaying = true;
        source.clip = son;
        source.Play();
    }

         if (Input.GetKeyDown(KeyCode.DownArrow))
    {
        isPlaying = true;
        source.clip = son;
        source.Play();
    }
    

    if ((Input.GetKeyUp(KeyCode.UpArrow) ||  Input.GetKeyUp(KeyCode.DownArrow)) && isPlaying)
    {
        isPlaying = false;
        source.Stop();
    }
}
}