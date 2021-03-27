using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform DispararY;

    public GameObject DispararPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(DispararPrefab, DispararY.position, Quaternion.identity);
        }
    }
}
