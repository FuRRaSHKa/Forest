using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalkaInteraction : Interaction {

    public Vector3 newLocalPos;

    private Transform player;
    private Fire fire;

    override protected void StartInteraction() {
    
        transform.SetParent(player);

        transform.localEulerAngles = Vector3.zero;

        transform.localPosition = (Vector3)newLocalPos;

        fire.PickupTorch();

        this.enabled = false;

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {

            fire = GetComponent<Fire>();

            player = collision.transform.GetChild(0);

            isNearby = true;

        }

    }

}
