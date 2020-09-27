using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4Open : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && ButtonFunctions.ButtonTurnOn == true)
        {
            if (ScoreScript.playerScore >=12)
            {
                Vector3 newPosition = new Vector3(transform.position.x, 1f, transform.position.z);
                transform.position = newPosition;
                Debug.Log("Open door");
            }

        }
    }
}
