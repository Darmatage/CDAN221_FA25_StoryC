using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

     public Rigidbody2D rb;
     public float moveSpeed = 5f;
     public Vector2 movement;
     public GameHandler_tree gameHandlerObj;
     public GameObject hitVFX;

     void Start(){
          rb = GetComponent<Rigidbody2D> ();
          if (GameObject.FindWithTag("GameHandler_tree") != null){
               gameHandlerObj = GameObject.FindWithTag("GameHandler_tree").GetComponent<GameHandler_tree>();
          }
     }

     void FixedUpdate(){
          movement.x = Input.GetAxisRaw ("Horizontal");
          rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
     }

     void OnCollisionEnter2D(Collision2D other){
          if (other.gameObject.tag == "tree"){
               gameObject.GetComponent<AudioSource>().Play();
               GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
               StartCoroutine(DestroyVFX(boomFX));

               Destroy(other.gameObject);
               gameHandlerObj.AddScore(1);
          }
          if (other.gameObject.tag == "eviltree"){
               gameObject.GetComponent<AudioSource>().Play();
               GameObject boomFX = Instantiate(hitVFX, other.gameObject.transform.position, Quaternion.identity);
               StartCoroutine(DestroyVFX(boomFX));

               Destroy(other.gameObject);
               gameHandlerObj.AddScore(-5);
          }
     }

     IEnumerator DestroyVFX(GameObject theEffect){
          yield return new WaitForSeconds(0.5f);
          Destroy(theEffect);
          gameObject.GetComponent<AudioSource>().Stop();
     }

}