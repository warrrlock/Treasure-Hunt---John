using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenScript : MonoBehaviour
{
    public static bool PlayerCollect;

    void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerCollect = true;
        ScoreScript.playerScore += 1;
        gameObject.SetActive(false);
        
    }
    public void OnTriggerExit2D(Collider2D other)
    {
       // PlayerCollect = false;
    }
}
