using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Teleport : MonoBehaviour
{
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == ("Play")) 
        {
            SceneManager.LoadScene("Game"); 
        }
    }
}