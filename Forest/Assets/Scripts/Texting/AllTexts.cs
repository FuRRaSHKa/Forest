using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTexts : MonoBehaviour {

    public TextClass textClass;

    public static AllTexts current;

    public string[] texts;

    private bool isTexting = false;

    private void Start() {

        if (current != null)
            Destroy(this);

        current = this;



        textClass.gameObject.SetActive(false);



    }


    public bool TextOn(int id) {

        if (isTexting)
            return false;

        textClass.gameObject.SetActive(true);
        textClass.StartPrinting(texts[id]);

        return true;

    }

    public void EndText() {

        isTexting = false;

    }

}
