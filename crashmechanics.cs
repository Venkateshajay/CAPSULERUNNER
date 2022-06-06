
using UnityEngine;

public class crashmechanics : MonoBehaviour
{
    public gamemanager gamemanager;
    public playermovement movement;
    private void OnTriggerEnter(Collider triggers)
    {
        
        if (triggers.tag=="gamefinished")
        {

            gamemanager.completed();

        }
    }
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().endgame();
        }

    }


}
