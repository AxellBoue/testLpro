using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    public Sprite interrupteurBas;
    public Sprite interrupteurHaut;
    SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        interrupteurHaut = rend.sprite; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        rend.sprite = interrupteurBas;
        GameObject.Find("porte").GetComponent<Porte>().OuvrePorte();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rend.sprite = interrupteurHaut;
        GameObject.Find("porte").GetComponent<Porte>().LanceTimer();
    }

}
