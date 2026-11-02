using UnityEngine;

public class PlaneController : MonoBehaviour

{
     public float moveSpeed = 10f;
     public float forwardSpeed = 15f;

     void Update(){
          float h = Input.GetAxis("Horizontal");
          float v = Input.GetAxis("Vertical");

          transform.Translate(
          h * moveSpeed * Time.deltaTime,
          v * moveSpeed * Time.deltaTime,
          forwardSpeed * Time.deltaTime
          );
     }
}
