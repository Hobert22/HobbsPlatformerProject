using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("The Player Has Stepped On The Staircase");
    }

}
