using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRaycaster : MonoBehaviour
{
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 20)){
            Debug.Log(hit.collider.gameObject.name);
            }//20 - dlina ray
        
    }
}
