using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace awesomeGame
{
    public class ScoreYazisi : MonoBehaviour
    {
        public TextMeshProUGUI scoreYazisi;
        public int scoresayisi=0;
        void Start()
        {
            scoresayisi = 0;
            

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
}

