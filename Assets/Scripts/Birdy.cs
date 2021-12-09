using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D rb2D;

    public bool isDead;
    public GameManager GameManager;
    
    public GameObject DeathScreen;
    
    private void Start() {
       Time.timeScale = 1;
    }
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
       {
          rb2D.velocity = Vector2.up *velocity;
       } 
       if(Input.GetKey("up"))
       {
          rb2D.velocity = Vector2.up *velocity;
       } 
    }
     private void OnTriggerEnter2D(Collider2D collision) {
        if( collision.gameObject.name == "ScoreArea" ) 
        {
           GameManager.UpdateScore();
        }
        
     }
     private void OnCollisionEnter2D(Collision2D collision) 
     {
   
        if( collision.gameObject.tag == "DeathArea" ) 
        {
           isDead = true;
           Time.timeScale = 0 ;
           DeathScreen.SetActive(true);
     }
     }
}

