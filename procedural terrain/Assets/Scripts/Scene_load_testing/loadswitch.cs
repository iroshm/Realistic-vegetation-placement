using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadswitch : MonoBehaviour
{
    
        public string levelLoad;

        public void switchscene(int sceneindex) {

            SceneManager.LoadScene(sceneindex);

        } 

        
   
}
