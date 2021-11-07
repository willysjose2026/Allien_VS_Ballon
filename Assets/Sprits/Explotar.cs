using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Explotar : MonoBehaviour
{
    public GameObject Gameover;

    public static bool IsOver = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ButtonWall" || collision.gameObject.name == "TopWall")
        {
            Destroy(this.gameObject);
            Time.timeScale = 0f;
            Gameover.SetActive(true);
            IsOver = true;
        }
    }

    private void Update()
    {
        
    }


    public void Restart()
    {
        if (IsOver)
        {
            IsOver = false;
            Gameover.SetActive(false);
            Time.timeScale = 1f;
            SceneManager.LoadScene("Inicio");
        }
    }
}
