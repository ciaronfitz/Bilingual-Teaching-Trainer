using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialog : MonoBehaviour
{
    [SerializeField] private GameObject toActivate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // change camera if needed
            // move player if needed
            // have avatar look at player

            // load GPT interface
            toActivate.SetActive(true);

            //display cursor
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;

        }

        //recover
    }
}
