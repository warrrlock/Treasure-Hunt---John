using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Open : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && ButtonFunctions.ButtonTurnOn == true)
        {
            if (ScoreScript.playerScore == 5)
            {
                Vector3 newPosition = new Vector3(transform.position.x, -3f, transform.position.z);
                transform.position = newPosition;
                Debug.Log("Open door");
            }
        }
    }
}
