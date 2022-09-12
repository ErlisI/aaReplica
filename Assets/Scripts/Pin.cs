using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    //public references
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update(){
      //moving the pin as long as its not pinned xD
      if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    //stopping the pin from moving when colliding with the rotator, and making it its child
    void OnTriggerEnter2D(Collider2D coll){

      if(coll.tag == "Rotator"){

        transform.SetParent(coll.transform);
        isPinned = true;

        Score.pCount++;

        if(Score.pCount >= 5 && Score.pCount <= 12){
          coll.GetComponent<Rotate>().speed *= -1;

        }else if(Score.pCount >= 13){
          coll.GetComponent<Rotate>().speed += 10;
        }

      }else if(coll.tag == "Pin"){
        //END THE Game
        FindObjectOfType<GameManager>().endGame();
      }
    }
}
