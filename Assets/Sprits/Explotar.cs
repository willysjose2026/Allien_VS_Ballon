using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotar : MonoBehaviour
{
    public GameObject Gameover;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ButtonWall" || collision.gameObject.name == "TopWall")
        {
            Destroy(this.gameObject);
            Gameover.SetActive(true);
        }
    }
}
