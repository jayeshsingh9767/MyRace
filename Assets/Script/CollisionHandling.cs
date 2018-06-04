using UnityEngine;

public class CollisionHandling : MonoBehaviour
{
    public MovePlayer mp;


    private void OnCollisionEnter(Collision collisionData)
    {
        if (collisionData.collider.tag == "obstacle") {            
            mp.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

    }

   
}
