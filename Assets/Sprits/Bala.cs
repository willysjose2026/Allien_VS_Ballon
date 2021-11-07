using UnityEngine.UI;
using UnityEngine;


public class Bala : MonoBehaviour
{
    public Text textScore;
    private static int score;
    private Collision2D collision;
    // Update is called once per frame


    public void Update()
    {
        transform.position -= transform.right * 20 * Time.deltaTime;
        
    }





    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puntos")
        {

            Destroy(this.gameObject);
            score += 1;
            textScore.text = $"Score: {score}";
            textScore.GetComponent<Text>().text = $"Score: {score}";
            Debug.Log(textScore.text);

        }
    }
}
