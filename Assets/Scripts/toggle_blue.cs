using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_blue : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject platform1;
    [SerializeField] private GameObject platform2;
    [SerializeField] private GameObject platform3;

    // Update is called once per frame
    private void OnTriggerEnter (Collider other){
        if(other.gameObject == player){
            platform1.gameObject.GetComponent<Animator>().enabled = true;
            platform2.gameObject.GetComponent<Animator>().enabled = true;
            platform3.gameObject.GetComponent<Animator>().enabled = true;
        }
    }
}
