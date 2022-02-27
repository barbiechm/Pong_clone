using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountManager : MonoBehaviour
{
    
    public static CountManager instance;
    public GameObject text_count1,text_count2;

    private int count_player1 = 0;
    private int count_player2 = 0;

    public int goal;
    
    void Awake()
    {
      instance = this;  
    }
    private void FixedUpdate()
    {
        //jugador 1
       Text puntaje1 = this.text_count1.GetComponent<Text>();
       puntaje1.text = this.count_player1.ToString();
       //jugador2
       Text puntaje2 = this.text_count2.GetComponent<Text>();
       puntaje2.text = this.count_player2.ToString();
    }

     void Update() 
     {
        if(count_player1 >= goal || count_player2 >= goal)
        {
            SceneManager.LoadScene("GameOver");
        }
  
     }
    //aumentar puntaje player1
    public void player1 ()
    {
     this.count_player1++;
    } 
    public void player2 () 
    {
     this.count_player2++;
    } 

}
