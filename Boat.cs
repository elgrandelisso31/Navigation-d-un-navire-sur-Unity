using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boat : MonoBehaviour

{
    // Code à exécuter en boucle

    public float speed = 5f;

    // Vitesse de déplacement en m/s après 6 secondes
    public float slowedSpeed = 2f;

    // Distance minimale à laquelle le navire doit être du quai pour débarquer
    public float dockDistance = 2f;

    // Le quai de destination
    public Transform dock;

    private bool isDocked = false;

    private float timer = 0f;
    private bool isSinking = false;

    private void Update()
    
    // Code à exécuter en boucle

    {
        if (isSinking)
        {
            // Si le navire coule, réduire sa position en Y jusqu'à -10 et le détruire
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
            return;
        }

        if (isDocked)
        {
            // Si le navire est amarré, ne rien faire
            return;
        }

        // Déplacer le navire en avant
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        // Incrémenter le timer
        timer += Time.deltaTime;

        // Si le temps écoulé est supérieur à 6 secondes, ralentir le navire
        if (timer >= 6f)
        {
            speed = slowedSpeed;
           
          
        }
        if (timer >= 12f)
        {
           
              Destroy(gameObject, 6f);
          
        }

        // Vérifier si le navire est suffisamment proche du quai pour s'amarrer
        if (Vector3.Distance(transform.position, dock.position) < dockDistance)
        {
            // Amarrer le navire au quai
            transform.parent = dock;
            transform.localPosition = Vector3.zero;
            isDocked = true;
            speed = 0f; // Arrêter le navire
            timer = 0f; // Réinitialiser le timer
            isSinking = true; // Couler le navire
        }
    }
   
}
