using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kucukcubuk;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            KucukCubukSpawn();
        }
    }

    

    void KucukCubukSpawn()
    {
        Instantiate(kucukcubuk, transform.position, transform.rotation);
    }
}
