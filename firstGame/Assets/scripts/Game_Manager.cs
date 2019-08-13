
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
    {
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
    }
    public void EndGame() {
        if (gameHasEnded==false) {
            gameHasEnded = true;
            Debug.Log("End");
            Invoke("Restart",restartDelay);
        }
    
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
