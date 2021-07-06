using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextClass : MonoBehaviour {


    public string needToPrint;
    public float printingSpeed = .2f;
    public float timeToWait;

    public TextMeshPro text;

    public void StartPrinting(string needToPrint) {

        this.needToPrint = needToPrint;

        StartCoroutine(Printing());

    }

    IEnumerator Printing() {



        text.text = "";

        for (int k = 0; k < needToPrint.Length; k++) {

            text.text += needToPrint[k];

            yield return new WaitForSeconds(printingSpeed);

        }

        yield return new WaitForSeconds(timeToWait);



        yield return new WaitForSeconds(timeToWait);

        AllTexts.current.EndText();

        gameObject.SetActive(false);
    }

}
