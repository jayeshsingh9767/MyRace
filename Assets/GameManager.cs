using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
    public bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;


    public void GameOver() {

        if (!gameEnded) {
            gameEnded = true;
            Debug.Log("Game Over!!");
            Invoke("Restart",restartDelay);
            
        }       
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void YouWon() {
        Debug.Log("Level Complete");
        levelCompleteUI.SetActive(true);
        
    }
}
