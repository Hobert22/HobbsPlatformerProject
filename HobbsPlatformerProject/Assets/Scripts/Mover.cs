using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MoveXSpeed;
    public float MoveYSpeed;
    public float MoveZSpeed;

    public float RotateXSpeed;
    public float RotateYSpeed;
    public float RotateZSpeed;
    void Update()
    {
        //MoveObject();
        RotateObject();
    }

    void MoveObject()
    {
        transform.position = transform.position + new Vector3(MoveXSpeed * Time.deltaTime, MoveYSpeed * Time.deltaTime, MoveZSpeed * Time.deltaTime);
    }

    void RotateObject()
    {
        transform.Rotate(new Vector3(RotateXSpeed * Time.deltaTime, RotateYSpeed * Time.deltaTime, RotateZSpeed * Time.deltaTime));
    }
}
