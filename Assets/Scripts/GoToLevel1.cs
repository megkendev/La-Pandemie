using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToLevel1 : MonoBehaviour
{
    public Button StartGame;

    // Start is called before the first frame update
    void Start()
    {
        StartGame.onClick.AddListener(goToGame);
    }

    void goToGame()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
