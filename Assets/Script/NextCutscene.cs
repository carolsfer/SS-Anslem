using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextCutscene : MonoBehaviour
{
    [SerializeField]

    private string nomeNextLvl;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(this.nomeNextLvl);
        }
    }
}
