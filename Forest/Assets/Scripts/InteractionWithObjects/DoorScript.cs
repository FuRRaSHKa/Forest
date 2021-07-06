using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public int id = 0;

    private SpriteRenderer spriteRenderer;
    private Collider2D collider2D;


    void Start() {

        EventController.current.onLeverArmUse += OpenDoor;
        EventController.current.onDoorClose += CloseDoor;

        collider2D = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }


    public void OpenDoor(int id) {

        if (this.id == id) {

            spriteRenderer.enabled = false;
            collider2D.enabled = false;

        }


    }

    public void CloseDoor(int id) {

        spriteRenderer.enabled = true;
        collider2D.enabled = true;

    }

}


