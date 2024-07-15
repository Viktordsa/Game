using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnCollisionEnter(Collision other){
        PlayerStats pStats;
        if(other.collider.TryGetComponent<PlayerStats>(out pStats)){
            pStats.coinCount += 1;
            Debug.Log(pStats.coinCount + " " + pStats.gameObject);
            Destroy(gameObject);
        } else{
            Debug.Log("no Player Stats");
        }
        
    }
    
}