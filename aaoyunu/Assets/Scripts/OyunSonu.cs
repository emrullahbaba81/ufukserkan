using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSonu : MonoBehaviour
{
    public GameObject DönenBüyükÇember;
    public GameObject Spawn;
   
   
    public void OyunuBitir()
    {
        DönenBüyükÇember.GetComponent<DonenBuyukCember>().enabled = false;
        Spawn.GetComponent<Spawn>().enabled = false;
       
    }
}
