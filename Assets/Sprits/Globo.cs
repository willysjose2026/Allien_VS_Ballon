using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globo : MonoBehaviour
{
    [SerializeField] Vector3 force;

    [SerializeField] Sprite[] balloonSprites;

    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Text score;
    private int Puntaje;

    void Start()
    {

        //Puntaje = 0;
        //score.text = "Score: " + score;

        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 5)];

        if (spriteRenderer.sprite == balloonSprites[1])
        {
            //Aqui se cambia la velocidad del globo azul(debe ser un numero negativo)
            rb.gravityScale = -0.06f;
            Debug.Log(rb.gravityScale);
        }
        else
        {
            rb.gravityScale = 0;
        }

        transform.position = new Vector3(Random.Range(-7.83f, 4.10f), transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(150, 250), 0);

        rb.AddForce(force);
    }

    // Update is called once per frame
    
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullets")
        {
            Destroy(this.gameObject);
        }
    }


}
