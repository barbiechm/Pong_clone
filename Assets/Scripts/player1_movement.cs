using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_movement : MonoBehaviour
{
   public float movementVelocity;

    private void FixedUpdate() 
    {
       float v = Input.GetAxisRaw("Vertical");
    
      GetComponent<Rigidbody2D>().velocity = new Vector2(0, v * movementVelocity);

    }
}
