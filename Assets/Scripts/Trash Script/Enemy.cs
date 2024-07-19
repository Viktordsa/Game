using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
Transform target;
public float move_speed;
public float rotation_speed;
public Transform enemy;
void Start(){
    target = Player.instance.transform;
}
void Update()
    {
        var look_dir = target.position - enemy.position;
        look_dir.y = 0;
        enemy.rotation = Quaternion.Slerp(enemy.rotation,Quaternion.LookRotation(look_dir),rotation_speed*Time.deltaTime);
        enemy.position += enemy.forward * move_speed * Time.deltaTime;
    }
}
//GameObject otherCharacter = GameObject.Find("Имя персонажа");
//Transform otherCharacterTransform = otherCharacter.transform;
//Vector3 otherCharacterPosition = otherCharacterTransform.position; 