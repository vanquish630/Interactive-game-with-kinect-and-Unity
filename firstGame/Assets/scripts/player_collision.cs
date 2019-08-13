
using UnityEngine;

public class player_collision : MonoBehaviour
{
    public player_Movement movement;


     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="obsticle") {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
