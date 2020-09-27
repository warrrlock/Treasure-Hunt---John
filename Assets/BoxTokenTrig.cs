using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTokenTrig : MonoBehaviour
{
    public GameObject boxToken;
    public GameObject button;
    public static bool lastdoorgood = false;
    private void Start()
    {
        boxToken.SetActive(false);
        button.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "movebox") {
            Debug.Log("BoxIn");
            boxToken.SetActive(true);
        }

        if (other.gameObject.name == "movebox2")
        {
            Debug.Log("BoxInKey");
            button.SetActive(true);
            lastdoorgood = true;
        }
    }
}
