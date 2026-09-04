using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    [SerializeField]

    private string nomeNextLvl;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        nextLvl();
    }

    private void nextLvl() 
    {
        SceneManager.LoadScene(this.nomeNextLvl);
    }
}