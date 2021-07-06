using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Interaction : MonoBehaviour {

    Animator anim;

    protected bool isNearby = false;

    private void Start() {

        anim = GetComponent<Animator>();

    }

    private void Update() {

        if (isNearby) {

            if (Input.GetAxis("Interaction") != 0) {

                StartInteraction();

                isNearby = false;

            }
        
        }

    }

    virtual protected void StartInteraction() {

        anim.SetTrigger("Interaction");

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player") {

            isNearby = true;
        
        }

    }

    private void OnTriggerExit2D(Collider2D collision) {

        if (collision.tag == "Player") {

            isNearby = false;

        }

    }

}
