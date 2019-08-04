using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSwoosh : MonoBehaviour
{
    private AudioSource swooshNoise;
    // Start is called before the first frame update
    void Start()
    {
        swooshNoise = GetComponent<AudioSource>();
        swooshNoise.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
