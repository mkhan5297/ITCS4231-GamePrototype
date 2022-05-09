using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{   
    private GameMaster gm;
    
   void Start(){
       gm = FindObjectOfType<GameMaster>();
       transform.position = gm.lastCheckPointPos;
   }

   

    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Restarted");
            
        }

       
        
    }

    
    



}
