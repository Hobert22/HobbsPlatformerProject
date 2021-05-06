using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedMechanics : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Interactive")
        {
            Debug.Log("Hello!");
            hit.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }

}