using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{

    public GameObject objectToToggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
                objectToToggle.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        objectToToggle.SetActive(true);
    }
}
