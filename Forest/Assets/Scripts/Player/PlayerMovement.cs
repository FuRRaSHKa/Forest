using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    public float speed = 1;

    private Rigidbody2D rgbd2d;
    private Animator anim;

    private float radianAngleOfScene = Mathf.PI / 4;

    private Vector2 direction;

    private void Start() {

        rgbd2d = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    // Start is called before the first frame update
    void Update() {

        

        direction = new Vector2(0, Input.GetAxis("Vertical") * Mathf.Cos(radianAngleOfScene));


        rgbd2d.velocity = direction * speed;

        float x = Input.GetAxis("Horizontal");

        if (x > 0) {

            anim.SetBool("Right", true);
            anim.SetBool("Left", false);
            anim.SetBool("Stop", false);

            direction.x = x;

        } else if (x < 0) {

            anim.SetBool("Left", true);
            anim.SetBool("Right", false);
            anim.SetBool("Stop", false);

            direction.x = x;

        } else {

            anim.SetBool("Stop", true);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);

        }

    }

    private void FixedUpdate() {

        rgbd2d.velocity = direction * speed;

    }


}
