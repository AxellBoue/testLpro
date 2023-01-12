using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public float compteur = 2;
    public bool timerOn = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            compteur -= 1 * Time.deltaTime;
            if(compteur <= 0)
            {
                timerOn = false;
                GetComponent<SpriteRenderer>().enabled = true;
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }

    public void OuvrePorte()
    {
        timerOn = false;
        compteur = 2;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    public void LanceTimer()
    {
        timerOn = true;
    }
}
