using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionControl : MonoBehaviour
{
  
  public Ball_Movement ballMovement;

  void bounceWithRacket(Collision2D c)
  {
      Vector2 positionBall = this.transform.position;

      Vector2 positionRacket = c.gameObject.transform.position;

      float alturaRaqueta = c.collider.bounds.size.y;

      float x;

      if(c.gameObject.name == "player_1")
      {
          x = 1;
      }
      else
      {
          x = -1;
      }

      float y = (positionBall.y - positionRacket.y) / alturaRaqueta;

      this.ballMovement.AumentarContador();
      this.ballMovement.BallMovement(new Vector2(x, y));
  }

   void OnCollisionEnter2D(Collision2D collision) 
  {
      if(collision.gameObject.name == "player_1"  || collision.gameObject.name == "player_2")
      {
        this.bounceWithRacket(collision);
      }else if(collision.gameObject.name == "left_walk")
      {
        CountManager.instance.player2();
        StartCoroutine(this.ballMovement.IniciarPelota(true));
      }
      else if(collision.gameObject.name == "right_walk")
      {
         CountManager.instance.player1();
         StartCoroutine(this.ballMovement.IniciarPelota(false));
      }
  }
}
