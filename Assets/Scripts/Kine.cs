using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kine : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other){
        if(other.gameObject == Player) transform.GetComponent<Rigidbody>().isKinematic = false;
    }
}
