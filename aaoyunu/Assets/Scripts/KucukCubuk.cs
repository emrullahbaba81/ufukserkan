using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk : MonoBehaviour
{
    
    Rigidbody2D rb;
    public float h�z;
    public bool hareketk�s�tl�;
    public GameObject y�netici;
    public static bool oyunbitti;
    void Start()
    {
        y�netici = GameObject.FindGameObjectWithTag("Y�netici");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (hareketk�s�tl� == false)
        {
            rb.MovePosition(rb.position+Vector2.up*h�z*Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DonenBuyukCember")
        {
            transform.SetParent(col.transform);
            hareketk�s�tl� = true;
        }

        if ( col.gameObject.tag == "KucukCember")
        {
            oyunbitti = true;
            y�netici.GetComponent<OyunSonu>().OyunuBitir();
            
        }


    }
}
