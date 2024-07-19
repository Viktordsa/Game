using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NDSTR : MonoBehaviour
{
    public float yOffset; 

    void Start()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y += yOffset;
        transform.position = currentPosition;
    }
}