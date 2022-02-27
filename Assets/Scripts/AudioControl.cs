using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    // Start is called before the first frame update
   public AudioSource sonidoRaqueta, soundWalk;

   private void OnCollisionEnter2D(Collision2D c)
   {
       if(c.gameObject.name == "player_1" || c.gameObject.name == "player_2")
       {
           this.sonidoRaqueta.Play();
       }else
       {
           soundWalk.Play();
       }
   }
}
