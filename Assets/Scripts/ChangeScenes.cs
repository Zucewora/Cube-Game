using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    
    private void Update() {
        if(Input.GetKeyUp(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(Input.GetKeyUp(KeyCode.Q)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        }
        if(Input.GetKeyUp(KeyCode.E)){
            if (SceneManager.GetActiveScene().buildIndex>0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
            }
        }   
    }
    private void OnTriggerEnter(Collider other) {
        if(this.CompareTag("Player") && other.CompareTag("Finish")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}

