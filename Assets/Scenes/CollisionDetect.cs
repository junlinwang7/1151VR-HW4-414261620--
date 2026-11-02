using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
     public AudioSource hitSound;

     void OnCollisionEnter(Collision col)
     {
          if(col.gameObject.CompareTag("Obstacle")){
               hitSound.Play();
          }
     }
}