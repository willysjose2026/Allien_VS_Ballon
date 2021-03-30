using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Velocidad = 20;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Velocidad * Time.deltaTime;
    }
}
