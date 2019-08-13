using UnityEngine.SceneManagement;
using UnityEngine;

public class Level_Complete : MonoBehaviour
{
    public void loadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
