using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{

    public float vitesse = 5;
    Rigidbody2D rb;
    float inputX;
    float inputY;
    Vector2 mouvement;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        mouvement = (new Vector2(inputX, inputY)).normalized * vitesse;
        rb.velocity = mouvement;
    }


}
