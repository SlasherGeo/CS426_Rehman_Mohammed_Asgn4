using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;

public class ClearData : NetworkBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Cleared Data!");

        if(collision.gameObject.CompareTag("output data")){
            GameObject[] dataObjs = GameObject.FindGameObjectsWithTag("input data");
            foreach(GameObject x in dataObjs){
                x.gameObject.GetComponent<NetworkObject>().Despawn();
                Destroy(x);
            }
        }
        collision.gameObject.GetComponent<NetworkObject>().Despawn();
        Destroy(collision.gameObject);
    }
}
