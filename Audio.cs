using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
          audio.Play();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
          audio.Play();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
          audio.Play();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
          audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
