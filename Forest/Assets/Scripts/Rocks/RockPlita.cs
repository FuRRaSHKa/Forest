using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPlita : MonoBehaviour {

    public int current = 1;

    private bool isPlayerInside = false;
    private bool isRockInside = false;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {

            if (!isRockInside)
                RockPlitaController.current.Increment();
            
            isPlayerInside = true;

            return;

        }

        if (collision.tag == "Rock") {

            if (!isPlayerInside)
                RockPlitaController.current.Increment();

            isRockInside = true;
            return;

        }

    }

    private void OnTriggerExit2D(Collider2D collision) {

        if (collision.tag == "Player") {

            if (!isRockInside)
                RockPlitaController.current.Decrement();

            isPlayerInside = false;
            return;
        }

        if (collision.tag == "Rock") {

            if (!isPlayerInside)
                RockPlitaController.current.Decrement();

            isRockInside = false;
            return;
        }

    }


}
