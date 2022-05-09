using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Keys : MonoBehaviour
{
   


         void Update()
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                 Restart();
                  
            }
        }

        void Restart(){

        
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
}
