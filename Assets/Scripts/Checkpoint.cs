using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    public GameObject Player;

    void Start(){
        gm = FindObjectOfType<GameMaster>();
    }
    private void OnTriggerEnter(Collider other)
    {
        gm.lastCheckPointPos = transform.position;
        Player.transform.parent = transform;
        Debug.Log("entered");
    }
    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;
        Debug.Log("exited");
    }
}