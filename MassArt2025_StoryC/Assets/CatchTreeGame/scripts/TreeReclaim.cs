using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeReclaim : MonoBehaviour {

      public Transform paddle;
      public float distanceToDestroy = 5f;
      public float distCheck;

      void Start(){
     //find the Paddle object by tag, then load its transform into our variable
            paddle = GameObject.FindWithTag("Player").GetComponent<Transform>();
      }

      void Update () {
            if (transform.position.y < (paddle.position.y - distanceToDestroy)){
                  Destroy(gameObject);
            }
     }
}