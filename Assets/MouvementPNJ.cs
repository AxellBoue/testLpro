using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementPNJ : MonoBehaviour
{
    
    Vector2 mouvement;
    Rigidbody2D rb;
    float compteur = 2;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mouvement = new Vector2(Random.Range(-1.0f, 1.0f),Random.Range(-1.0f,1.0f));
        mouvement = mouvement.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        compteur -= 1 * Time.deltaTime;
        if(compteur <= 0)
        {
            mouvement = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            mouvement = mouvement.normalized;
            compteur = Random.Range(0.5f, 3);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = mouvement;
    }
}
