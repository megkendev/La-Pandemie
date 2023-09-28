using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel3 : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
}
