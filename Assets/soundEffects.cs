using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour
{
    public AudioSource coinCollect;
    public AudioSource DoorOpen;
    public AudioSource InvisReveal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TokenScript.PlayerCollect == true) {
            coinCollect.Play();
        }
    }
}
