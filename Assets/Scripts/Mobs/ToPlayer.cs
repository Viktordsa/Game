using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
public class ToPlayer : MonoBehaviour
{
    Transform target;
    public float approachSpeed = 1;
    void Start(){
        target = Player.instance.transform;
    }
    void Update(){
        var direction = (target.position - transform.position).normalized;
        transform.position += direction * Time.deltaTime * approachSpeed;
    }
}

