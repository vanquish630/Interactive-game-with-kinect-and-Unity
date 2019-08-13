
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public Game_Manager GameManager;
     void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
    }
}
