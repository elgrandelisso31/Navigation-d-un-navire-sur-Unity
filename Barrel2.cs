using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel2 : MonoBehaviour {
    public Transform dock;
    public float destroyDistance;

    void Update() {
        float distance = Vector3.Distance(transform.position, dock.position);
        if (distance < destroyDistance) {
            transform.parent=dock;
            transform.localPosition = new Vector3(-1.81669998f ,1.3628f,2.84890008f);

        }
    }
}

