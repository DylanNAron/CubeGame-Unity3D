using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
       
        if(collisionInfo.collider.tag== "Obstacle"){

            movement.enabled = false;
        }
        if (collisionInfo.collider.name == "Lava")
        {

            movement.enabled = false;
        }
    }

}