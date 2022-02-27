using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
  
  public float movementVelocity;
  public GameObject ball;
  public int velocityOfAlcance;

  void FixedUpdate()
  {
      if(Mathf.Abs(this.transform.position.y - ball.transform.position.y) > velocityOfAlcance)
      {
         
        if(transform.position.y < ball.transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * movementVelocity;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * movementVelocity;
        }
      }else
      {
          GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
      }

  }

}
