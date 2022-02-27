using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float velocity_Movement;
    public float extraVelocity;
    public float extraVelocityMax;

    int contadorGolpes = 0;

    void Start()
    {
       StartCoroutine(this.IniciarPelota());
    }

    public IEnumerator IniciarPelota(bool comienzaJugador1 = true)
    {
       this.PosicionarPelota(comienzaJugador1);

       this.contadorGolpes = 0;
 
       yield return new WaitForSeconds(2); //wait for begin

       if(comienzaJugador1)
       {
           this.BallMovement(new Vector2(-1,0));
       }else
       {
           this.BallMovement(new Vector2(1, 0));
       }
    }

    //reposicionar pelota

    public void PosicionarPelota(bool comienzaJugador1)
    {
       this.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

       if(comienzaJugador1 == true)
       {
           this.gameObject.transform.localPosition = new Vector3(-195.3f, 1.72f, 24);
       }else
       {
           this.gameObject.transform.localPosition = new Vector3(-192.03f,1.72f, 24);
       }

    }
      //administrar velocidad
    public void BallMovement(Vector2 dir)  //
    {
        dir = dir.normalized;  //normalizar la velocidad

        float velocidad = velocity_Movement + contadorGolpes * extraVelocity; //calcular con parámetros especificos

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * velocidad;
    }
        // aumentar velocidad por golpe
    public void AumentarContador()
    {
        if(this.contadorGolpes * this.extraVelocity <= this.extraVelocityMax )
        {
            this.contadorGolpes++;
        }
    }

}
