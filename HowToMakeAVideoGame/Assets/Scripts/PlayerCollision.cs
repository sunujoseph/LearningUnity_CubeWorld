using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement; // a reference to out PlayerMovement script



    //function runs when we hit another object
    // information about the collision from collisionInfo
    void OnCollisionEnter (Collision collisionInfo)
    {
        // check if object collided with a tag called obstacle
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false; // disables the players movement.
            // GetComponent<PlayerMovement>().enabled = false; does the same above
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
