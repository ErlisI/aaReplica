using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject pin;

    void Update() {

      if(Input.GetButtonDown("Jump") || Input.GetButtonDown("Fire1")){ //clicking space and mouse click to spawn pins

        spawnPin();

      }
    }

    //spawns pins from the spawn point
    void spawnPin(){

      Instantiate(pin, transform.position, transform.rotation);

    }
}
