using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float speed = 100f;

    //rotating the target at constant speed
    void Update() {

      transform.Rotate(0f, 0f, speed * Time.deltaTime);

    }
}
