using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenü : MonoBehaviour
{
   public void oynabutonu()
    {
        SceneManager.LoadScene(1);
    }

    public void cıkısbutonu()
    {
        Application.Quit();
    }
}
