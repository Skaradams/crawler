using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
  private Rigidbody2D body;
  public float speed = 10.0F;

  void Start() {
    body = GetComponent<Rigidbody2D>();
  }
  void Update() {
    float horizontalSpeed = Input.GetAxis("Horizontal") * speed;
    float verticalSpeed = Input.GetAxis("Vertical") * speed;
    Vector2 movement = new Vector2(horizontalSpeed, verticalSpeed);
    body.MovePosition(body.position + movement * Time.fixedDeltaTime);
  }
}
