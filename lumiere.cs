using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lumiere : MonoBehaviour
{
    public float rotationSpeed = 10f; // La vitesse de rotation
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // Tourner la lumière autour de l'axe X
    }
}
