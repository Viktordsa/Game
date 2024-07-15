using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraRotator : MonoBehaviour
{
    public float horizontalRotationSpeed = 5;
    void Update(){
        float mouseInput = Input.GetAxis("Mouse X");
        if (mouseInput != 0){
            float RotationAngle = horizontalRotationSpeed * mouseInput * Time.deltaTime;
            transform.Rotate(0, RotationAngle, 0);
        }
    }
}
