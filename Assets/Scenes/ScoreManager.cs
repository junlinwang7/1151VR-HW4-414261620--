using UnityEngine;

public class ScoreManager : MonoBehaviour
{
     public static int score = 0;

public static void AddScore()
{
          score++;
          Debug.Log("Score :" + score);
     }
}
