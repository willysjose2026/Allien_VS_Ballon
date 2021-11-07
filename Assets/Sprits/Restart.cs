using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private Explotar explotar = new Explotar();
    // Start is called before the first frame update
    public void restart()
    {
        explotar.Restart();
    }
}
