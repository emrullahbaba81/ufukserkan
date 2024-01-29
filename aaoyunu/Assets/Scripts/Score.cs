using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreYazisi : MonoBehaviour
{
    public TextMeshProUGUI scoreYazisi;
    public int scoresayisi;
    void Start()
    {
        scoresayisi = 0;
        scoreYazisi.text = "Score:" + scoresayisi;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scoresayisi++;
            scoreYazisi.text = "Score:" + scoresayisi;

        }
    }
}
