using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouve : MonoBehaviour {
    public float speed = 1f;
    private bool movingForward = true;
    private Vector3 startingPosition;
    
    void Start() {
        startingPosition = transform.position;
    }
    
    void Update() {
        if (movingForward) {
            transform.position = Vector3.MoveTowards(transform.position, startingPosition + Vector3.right * 2f, speed * Time.deltaTime);
            if (transform.position == startingPosition + Vector3.right * 2f) {
                movingForward = false;
            }
        } else {
            transform.position = Vector3.MoveTowards(transform.position, startingPosition, speed * Time.deltaTime);
            if (transform.position == startingPosition) {
                movingForward = true;
            }
        }
    }
}


