using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject Player;

    public bool move = true;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject == Player) Player.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject == Player) Player.transform.parent = null;
    }
}
