using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane2Movement : MonoBehaviour {

  public System.Random random = new System.Random();
  public Rigidbody2D rigid;
  public float speed = 7.0f;
  int direction = 1;
  int top = 5;
  int bottom = -5;

  void Start()
  {
    if (rigid == null)
      rigid = GetComponent<Rigidbody2D>();
  }


  // Use this for initialization

   void Update () 
    {
        if (transform.position.y >= top)
            direction = -1;

        if (transform.position.y <= bottom)
            direction = 1;

        transform.Translate(0, speed * direction * Time.deltaTime, 0);
	}

}