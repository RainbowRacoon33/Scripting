using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Declaración de variables
    int lives = 5;
    int level = 18;
    public float speed = 5f;
    Vector3 newPosition;
    void Start()
    {
        //Suma de las vidas y el nivel y asignación a las vidas
        lives += level;
        //Impresión de las vidas (Después de los cálculos)
        print("lives: " + lives);
    }

    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
