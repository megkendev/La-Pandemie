using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
}
