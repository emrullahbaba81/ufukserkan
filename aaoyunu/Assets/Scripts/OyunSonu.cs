using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonu : MonoBehaviour
{
    public GameObject D�nenB�y�k�ember;
    public GameObject Spawn;
   
   
    public void OyunuBitir()
    {
        D�nenB�y�k�ember.GetComponent<DonenBuyukCember>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
       
    }
}
