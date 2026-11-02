using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PassDetector : MonoBehaviour
{
     public AudioSource successSound;
    void OnTriggerEnter(Collider other)
     {
         if(other.CompareTag("Player")){
               ScoreManager.AddScore();
               successSound.Play();
          }
     }
}
