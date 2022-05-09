using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    private GameMaster gm;
   public GameObject Player;
void Start(){
        gm = FindObjectOfType<GameMaster>();
    }
    
    private void OnTriggerEnter(Collider other)
    {

       Vector3 myVector = new Vector3(-766,-29,-153);
        gm.lastCheckPointPos = myVector;
        SceneManager.LoadScene("Level 2");
        Debug.Log("entered");
    }
    private void OnTriggerExit(Collider other)
    {
        Player.transform.parent = null;
        Debug.Log("exited");
    }
}
