using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private AudioSource audioSource;
    private float fl = 0.1f;
    private void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other){
        
        PlayerStats pStats;
        if(other.collider.TryGetComponent<PlayerStats>(out pStats)){
            pStats.coinCount += 1;
            Debug.Log(pStats.coinCount + " " + pStats.gameObject);
            audioSource.Play();
            Destroy(gameObject, fl);
        } else{
            Debug.Log("no Player Stats");
        }
        
    }    
}

