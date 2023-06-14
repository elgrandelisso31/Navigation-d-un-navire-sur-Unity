using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour {
    public Transform dock;
    public float destroyDistance;

    void Update() {
        float distance = Vector3.Distance(transform.position, dock.position);
        
        if (distance < destroyDistance) {
            transform.parent=dock;
            transform.localPosition = new Vector3(-0.164000005f, 1f, 0.458000004f);

        }
    }
}
