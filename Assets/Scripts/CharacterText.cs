using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    
using DG.Tweening;

public class CharacterText : MonoBehaviour
{

    public string[] dialogLines;
    public TextMeshProUGUI characterText;


    public CanvasGroup textHolder;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showCharacterMsg(){
        textHolder.DOFade(1,2);
        StartCoroutine(startDialog());
    }


    IEnumerator startDialog(){

        int lineCount = 0;
        foreach(string line in dialogLines ){
            characterText.text = dialogLines[lineCount];
            yield return new WaitForSeconds(2);
            lineCount++;
        }

        textHolder.DOFade(0,1).SetDelay(4);
    }
}
