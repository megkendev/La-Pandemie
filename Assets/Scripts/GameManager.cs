using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public void Start() {
        // UIManager.instance.showGameMsg("MEMORIES");
    }
    
    public void GameOver(){
        UIManager.instance.showGameMsg("WHAT'S NEXT?");
    }
}
