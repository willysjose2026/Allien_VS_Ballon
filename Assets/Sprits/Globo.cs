using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    [SerializeField] Vector3 force;

    [SerializeField] Sprite[] balloonSprites;

    private Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    private int Puntaje;

    void Start()
    {
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
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "TopWall")
        {
            Destroy(this.gameObject);
        }
    }
}
