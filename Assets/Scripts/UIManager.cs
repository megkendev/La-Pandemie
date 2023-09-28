using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI gameMsgText;
    public TextMeshProUGUI scoreText;
    public static UIManager instance;

    private int score =0;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void Update() 
    {

    }

    public void showGameMsg(string msg)
    {
        gameMsgText.text = msg;
        gameMsgText.DOFade(1,3);
        gameMsgText.DOFade(0,3).SetDelay(3);
    }

}
