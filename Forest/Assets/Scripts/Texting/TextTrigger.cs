using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour {

    public int id = 0;


    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {

            AllTexts.current.TextOn(id);

            gameObject.SetActive(false);

        }



    }






}
