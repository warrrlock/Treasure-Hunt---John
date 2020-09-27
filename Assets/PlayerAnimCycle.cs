using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimCycle : MonoBehaviour
{
    public Sprite[] walkAnim = new Sprite[4];
    public Sprite idleAnim;
    public Sprite jumpAnim;
    private int currentFrame;
    public float animFPS = 10;
    private float previousFrameTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = walkAnim[currentFrame];

            if (Time.time - previousFrameTime > 1 / animFPS)
            {
                previousFrameTime = Time.time;
                currentFrame++;
                if (currentFrame > walkAnim.Length - 1) currentFrame = 0;
            }
        }
        else {
            gameObject.GetComponent<SpriteRenderer>().sprite = idleAnim;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = jumpAnim;
        }
      
    }
}