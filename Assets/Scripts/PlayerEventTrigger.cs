using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEventTrigger : MonoBehaviour
{

 [SerializeField]
 public UnityEvent PlayerTriggerEnter,PlayerTriggerExit;
   
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            PlayerTriggerEnter?.Invoke();
        }     
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.CompareTag("Player")){
            PlayerTriggerExit?.Invoke();
        }     
    }


}
