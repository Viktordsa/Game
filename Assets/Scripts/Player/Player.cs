using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int health;
    void OnEnable(){
        instance = this;
    }
}