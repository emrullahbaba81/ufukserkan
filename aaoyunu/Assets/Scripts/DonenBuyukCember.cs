using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonenBuyukCember : MonoBehaviour
{
    // Start is called before the first frame update
    public float h�z;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, h�z * Time.deltaTime);
    }
}
